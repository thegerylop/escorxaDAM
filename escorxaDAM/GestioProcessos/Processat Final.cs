using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;
using Models;

namespace GestioProcessos
{
    public partial class Processat_Final : BaseInserir
    {
        ClassHelpers.EDI_TCPhelpers tcp = new ClassHelpers.EDI_TCPhelpers();
        escorxadam2Entities _m = new escorxadam2Entities();

        string lot;
        double pes;
        string estat;
        public Processat_Final()
        {
            InitializeComponent();
        }

        private void Processat_Final_Load(object sender, EventArgs e)
        {
            MenuPrincipal.MenuPrincipal m = ParentForm as MenuPrincipal.MenuPrincipal;
            updateGrid();
            comboTipus.SelectedIndex = 1;
            obtenirUsuaris();
            txtBoxUsuari.SelectedValue = m.User;
        }
        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            txtBoxUsuari.DataSource = usuaris;
            txtBoxUsuari.DisplayMember = "Nom";
            txtBoxUsuari.ValueMember = "idUsuari";
        }
        private void updateGrid()
        {
            //Agafo les dades
            var dades = (from procFinal in _m.processats_finals
                         join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                         join c in _m.estat_processos_envasat on procFinal.idEstatEnvasat equals c.idEstatProcesEnvasat
                         where (c.nomEstatProcesEnvasat == "En espera" || c.nomEstatProcesEnvasat == "En procés")
                         select new { lots.numLot, c.nomEstatProcesEnvasat }).ToArray();
            //Fico les dades
            SafataGrid.DataSource = dades;
        }

        private void SafataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dadesDataGrid(e);
            omplirCampsComuns();
            if (comboTipus.SelectedItem.ToString().Length > 0)
            {
                btnPes.Enabled = true;
                btnAnalisi.Enabled = false;
                btnInserir.Enabled = false;
            }
        }
        private void omplirCampsComuns()
        {
            txtBoxLot.Text = lot;
            txtBoxDIB.Text = pes.ToString();
            txtEstat.Text = estat;
        }
        private void dadesDataGrid(DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            lot = SafataGrid.Rows[num].Cells[0].Value.ToString();
            estat = SafataGrid.Rows[num].Cells[1].Value.ToString();
            pes = 0;
            var dades = (from procFinal in _m.processats_finals
                         join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                         join recepcio in _m.recepcions_bestiar on lots.idRemo equals recepcio.idRecepcio
                         join anim in _m.animals on recepcio.idRecepcio equals anim.idRecepcioBestiar
                         where lots.numLot == lot
                         select anim.Pes).ToArray();
            foreach (double item in dades)
            {
                pes += item;
            }
            txtBoxDIB.Text = pes.ToString();
        }

        private void btnPes_Click(object sender, EventArgs e)
        {
            string tipus = comboTipus.SelectedItem.ToString();
            string pesBal = tcp.sendUDPData("172.17.21.32", 7000, tipus);
            PesBalança.Text = pesBal;
            comprobarPes(pesBal);
        }
        private void comprobarPes(string pesBalança)
        {
            double pesFinal = Int64.Parse(pesBalança);
            if (comboTipus.SelectedItem.ToString() == "SN")
            {
                if (pesFinal >= 360 && pesFinal <= 440)
                {
                    MessageBox.Show("Pes Correcte");
                    btnAnalisi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pes Incorrecte");
                    safataIncorrecte();
                }
            }
            else if (comboTipus.SelectedItem.ToString() == "SF")
            {
                if (pesFinal >= 1080 && pesFinal <= 1320)
                {
                    MessageBox.Show("Pes Correcte");
                    btnAnalisi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pes Incorrecte");
                    safataIncorrecte();
                }
            }
            else
            {
                if (pesFinal >= 720 && pesFinal <= 880)
                {
                    MessageBox.Show("Pes Correcte");
                    btnAnalisi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pes Incorrecte");
                    safataIncorrecte();
                }
            }
        }
        private void btnAnalisi_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            string tipus = comboTipus.SelectedItem.ToString();
            string dadesEspectograf = tcp.sendTCPData("172.17.20.249", 5000, tipus);
            string[] output = dadesEspectograf.Split(',');
            comprobarEspectograf(output);
            txtBoxO2.Text = output[1];
            txtBoxCO2.Text = output[0];
            txtBoxMG.Text = output[2];

        }
        private void comprobarEspectograf(string[] espe)
        {
            int[] arrayeEspe = Array.ConvertAll(espe,
                                  delegate (string s) { return int.Parse(s); });
            if (arrayeEspe[0] >= 20 && arrayeEspe[0] <= 30)
            {
                if (arrayeEspe[1] >= 65 && arrayeEspe[1] <= 80)
                {
                    if (arrayeEspe[2] >= 1 && arrayeEspe[2] <= 3)
                    {
                        btnInserir.Visible = true;
                        MessageBox.Show("Analisi finalitzar correctament");
                    }
                    else
                    {
                        MessageBox.Show("Analisi incorrecte");
                        safataIncorrecte();
                    }
                }
                else
                {
                    MessageBox.Show("Analisi incorrecte");
                    safataIncorrecte();
                }
            }
            else
            {
                MessageBox.Show("Analisi incorrecte");
                safataIncorrecte();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyy/MM/dd HH:mm");
            txtDateCad.Text = DateTime.Now.AddDays(20).ToString("yyy/MM/dd");

            int referencia = Int32.Parse((from a in _m.referencies
                                          select a.nomReferencia).Max());
            referencia += 1;
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                var re = new referencies
                {
                    nomReferencia = referencia.ToString(),
                };
                _m.referencies.Add(re);
                _m.SaveChanges();


                var proc = (from procFinal in _m.processats_finals
                            join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                            where lots.numLot == lot
                            select procFinal).FirstOrDefault();
                var idSaf = (from safata in _m.referencies
                             select safata.idReferencia).Max();

                proc.idUsuari = Int32.Parse(txtBoxUsuari.SelectedValue.ToString());
                proc.dataEnvasat = DateTime.ParseExact(txtDate.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                proc.diaCaducitat = DateTime.ParseExact(txtDateCad.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                proc.idEstatEnvasat = 3;
                proc.idSafata = idSaf;
                proc.percCO2 = Convert.ToDouble(txtBoxCO2.Text);
                proc.percO2 = Convert.ToDouble(txtBoxO2.Text);
                proc.Mioglobina = Convert.ToDouble(txtBoxMG.Text);
                proc.pesSafata = Convert.ToDouble(PesBalança.Text);

                _m.SaveChanges();
            }
            imprimirTicket();
        }
        private void safataIncorrecte()
        {
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                var proc = (from procFinal in _m.processats_finals
                            join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                            where lots.numLot == lot
                            select procFinal).FirstOrDefault();
                proc.idEstatEnvasat = 4;

                _m.SaveChanges();
            }
            updateGrid();
            btnAnalisi.Enabled = false;
            btnInserir.Enabled = false;
            btnPes.Enabled = false;
        }
        private void imprimirTicket()
        {

        }
    }
}
