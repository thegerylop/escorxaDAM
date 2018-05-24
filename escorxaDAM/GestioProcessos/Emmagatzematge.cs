using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;
using Models;
using ClassHelpers;
using System.Globalization;

namespace GestioProcessos
{
    public partial class Emmagatzematge : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        ClassHelpers.EDI_TCPhelpers edi = new ClassHelpers.EDI_TCPhelpers();
        string lot;
        string estat;

        public Emmagatzematge()
        {
            InitializeComponent();
        }
        private void Emmagatzematge_Load(object sender, EventArgs e)
        {
            MenuPrincipal.MenuPrincipal m = ParentForm as MenuPrincipal.MenuPrincipal;
            actualitzarDataGrid();
            obtenirUsuaris();
        }
        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            UsuarisEntrada.DataSource = usuaris;
            UsuarisEntrada.DisplayMember = "Nom";
            UsuarisEntrada.ValueMember = "idUsuari";
            UsuarisSortida.DataSource = usuaris;
            UsuarisSortida.DisplayMember = "Nom";
            UsuarisSortida.ValueMember = "idUsuari";
        }

        private void dgwEmmagatzematge_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MenuPrincipal.MenuPrincipal m = ParentForm as MenuPrincipal.MenuPrincipal;
            dadesDataGrid(e);
            omplirCampsComuns();
            if (estat.Equals("En espera"))
            {
                btnInserir.Visible = true;
                btnTreure.Visible = false;
                UsuarisEntrada.SelectedValue = m.User;

            }
            else
            {
                btnInserir.Visible = false;
                btnTreure.Visible = true;
                omplirCampsProces();
                UsuarisSortida.SelectedValue = m.User;

            }

        }
        private void dadesDataGrid(DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            lot = dgwEmmagatzematge.Rows[num].Cells[0].Value.ToString();
            estat = dgwEmmagatzematge.Rows[num].Cells[1].Value.ToString();
        }
        private void omplirCampsComuns()
        {
            txtLot.Text = lot;
            txtEstat.Text = estat;
        }

        private void omplirCampsProces()
        {
            var emmagatzematge = (from a in _m.lots
                           join b in _m.emmagatzematges on a.idEmmagatzematge equals b.idEmmagatzematge
                           where a.numLot == lot
                           select b).FirstOrDefault();
            UsuarisEntrada.SelectedValue = emmagatzematge.idUsuariEntrada;
            txtNumCamFrigo.Text = emmagatzematge.numCambraFrigorifica.ToString();
            dataEntrada.Text = emmagatzematge.dataEntrada.ToString();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            omplirCampsEspera();
            afegirBBDD();
        }
        private void omplirCampsEspera()
        {
            Random random = new Random();
            txtNumCamFrigo.Text = random.Next(1, 30).ToString();
            dataEntrada.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
        }

        private void btnTreure_Click(object sender, EventArgs e)
        {
            //data sortida
            dateOut.Text = DateTime.Now.AddHours(07).ToString("yyyy/MM/dd HH:mm");
            string tempsMax = (DateTime.Now.AddHours(07).Hour + obtenirHoraCorrecta(DateTime.Now.Minute.ToString())).ToString();

            string ip = "127.0.0.1";

            //data entrada
            int change = dataEntrada.Text.IndexOf(" ");
            string tempsMin = dataEntrada.Text.Substring(change + 1);
            string[] horas = tempsMin.Split(':');
            string hora = obtenirHoraCorrecta(horas[1]);
            tempsMin = horas[0] + hora;

            //Hora entrada - hora sortida
            string query = tempsMin + "-" + tempsMax;

            string temps = edi.sendUDPData(ip,8000, query);

            //Recupero les temperaturas max i min.
            int changes = temps.IndexOf("-");
            string tempMin = temps.Substring(0, changes);
            string tempMax = temps.Substring(changes + 1);
            txtMaxTemp.Text = tempMax;
            txtMinTemp.Text = tempMin;
            int tempMinima = Int32.Parse(tempMin);
            int tempMaxima = Int32.Parse(tempMax);

            //Comprovo que las temperatures siguin correctes
            if (tempMinima < 200 || tempMaxima > 500)
            {
                txtEstat.Text = "Defectuós";
                MessageBox.Show("Defectuós");
            }
            else
            {
                txtEstat.Text = "Correcte";
                MessageBox.Show("Correcte");
            }
            afegirBBDD();
            if(txtEstat.Text == "Correcte")
            {
                finalitzarProces();
            }


        }

        public string obtenirHoraCorrecta(string hora)
        {
            int horas = Int32.Parse(hora);
            if(horas > 15 && horas < 30)
            {
                hora = "15";
            }
            else if (horas > 30 && horas < 45)
            {
                hora = "30";
            }
            else if (horas > 45 && horas < 00)
            {
                hora = "45";
            }
            else
            {
                hora = "00";
            }
            return hora;
        }
        private void actualitzarDataGrid()
        {

            btnInserir.Visible = false;
            btnTreure.Visible = false;
            //Tornem a fer la select per carregar-ho tot
            var num = (from a in _m.emmagatzematges
                       join b in _m.usuaris on a.idUsuariEntrada equals b.idUsuari
                       join c in _m.estat_refrigeracions on a.idEstatRefrigeracio equals c.idEstatRefrigeracio
                       join d in _m.lots on a.idEmmagatzematge equals d.idEmmagatzematge
                       where (c.nomEstatRefrigeracio == "En espera" || c.nomEstatRefrigeracio == "En procés")
                       select new { d.numLot, c.nomEstatRefrigeracio }).ToArray();

            dgwEmmagatzematge.DataSource = num;
        }
        private void afegirBBDD()
        {
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                string idLot = (from a in _m.lots
                                where a.numLot.ToString() == txtLot.Text
                                select a.idEmmagatzematge).First().ToString();
                var emm = (from a in _m.emmagatzematges
                           where a.idEmmagatzematge.ToString() == idLot
                           select a).FirstOrDefault();

                if (emm.idEstatRefrigeracio == 1)
                {
                    emm.idUsuariEntrada = Int32.Parse(UsuarisEntrada.SelectedValue.ToString());
                    emm.idUsuariSortida = 1;
                    emm.idEstatRefrigeracio = 4;
                    emm.numCambraFrigorifica = Int32.Parse(txtNumCamFrigo.Text);
                    emm.dataEntrada = DateTime.ParseExact(dataEntrada.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    MessageBox.Show("Inserit Correctament");

                }
                else
                {
                    if(txtEstat.Text == "Defectuós")
                    {
                        emm.idEstatRefrigeracio = 3;
                    }
                    else
                    {
                        emm.idEstatRefrigeracio = 2;
                    }
                    emm.idUsuariSortida = Int32.Parse(UsuarisSortida.SelectedValue.ToString());
                    emm.dataSortida = DateTime.ParseExact(dateOut.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    emm.temperaturaMaxima = Int64.Parse(txtMaxTemp.Text);
                    emm.temperaturaMinima = Int64.Parse(txtMinTemp.Text);
                }

                _m.SaveChanges();
                actualitzarDataGrid();
            }
        }

        public void finalitzarProces()
        {
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                var fin = new processats_finals
                {
                    idUsuari = 1,
                    idSafata = 1,
                    idEstatEnvasat = 1,
                };
                _m.processats_finals.Add(fin);
                _m.SaveChanges();
                var lotes = _m.lots.OrderByDescending(u => u.numLot == txtLot.Text).FirstOrDefault();
                long idProcessatFinal = (from a in _m.processats_finals
                                    select a.idProcessatFinal).Max();

                lotes.idProcessatFinal = idProcessatFinal;
                _m.SaveChanges();
            }
            MessageBox.Show("Finalitzat");
        }
    }
}
