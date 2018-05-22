using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace GestioProcessos
{
    public partial class Estabulacio : BaseForm.BaseInserir
    {

        escorxadam2Entities _m = new escorxadam2Entities();
        string lot;
        string estat;

        public Estabulacio()
        {
            InitializeComponent();
        }

        private void Estabulacio_Load(object sender, EventArgs e)
        {
            ActualitzarDataGrid();
            obtenirUsuaris();
        }
        private void ActualitzarDataGrid()
        {
            var num = (from a in _m.lots
                       join b in _m.estables on a.idEstabulacio equals b.idEstable
                       join c in _m.estat_estabulacions on b.idEstatEstabulacio equals c.idEstatEstabulacio
                       where (c.nomEstatEstabulacio == "En espera" || c.nomEstatEstabulacio == "En procés")
                       select new { a.numLot, c.nomEstatEstabulacio }).ToArray();
            estabulacioDataGrid.DataSource = num;
        }
        private void estabulacioDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dadesDataGrid(e);
            omplirCampsComuns();
            omplirCampsEspera();
            if (estat.Equals("En espera"))
            {
                btnInserir.Visible = true;
                omplirCampsEspera();
            }
            else
            {
                btnFinalitzar.Visible = true;
                omplirCampsProces();

            }

        }
        private void dadesDataGrid(DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            lot = estabulacioDataGrid.Rows[num].Cells[0].Value.ToString();
            estat = estabulacioDataGrid.Rows[num].Cells[1].Value.ToString();
        }
        private void omplirCampsComuns()
        {
            Lots.Text = lot;
            Estats.Text = estat;
        }
        private void omplirCampsEspera()
        {
            Random rnd = new Random();
            NumEstable.Text = rnd.Next(1, 11).ToString();
            DiaEntrada.Text = DateTime.Now.ToString("yyy/MM/dd HH:mm");
        }
        private void omplirCampsProces()
        {
                var estable = (from a in _m.lots
                               join b in _m.estables on a.idEstabulacio equals b.idEstable
                               where a.numLot == lot
                               select b).FirstOrDefault(); ;
            NumEstable.Text = estable.numEstable;
            Incidencies.Text = estable.Incidencies;
            Usuaris.SelectedValue = estable.idUsuariResponsable;
            DiaEntrada.Text = estable.dataEntrada.ToString();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            omplirCampsEspera();
            afegirBBDD();
        }

        private void btnFinalitzar_Click(object sender, EventArgs e)
        {
            DiaSortida.Text = DateTime.Now.ToString("yyy/MM/dd HH:mm");
            afegirBBDD();
            finalitzarProces();
        }
        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            Usuaris.DataSource = usuaris;
            Usuaris.DisplayMember = "Nom";
            Usuaris.ValueMember = "idUsuari";
        }
        private void afegirBBDD()
        {
            string incidencia;
            if (Incidencies.Text == "")
            {
                incidencia = "Cap incidencia";
            }
            else
            {
                incidencia = Incidencies.Text;
            }
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                string idEst = (from a in _m.lots
                                            where a.numLot.ToString() == Lots.Text
                                            select a.idEstabulacio).First().ToString();
                var est = (from a in _m.estables
                           where a.idEstable.ToString() == idEst 
                           select a).FirstOrDefault();

                if(est.idEstatEstabulacio == 1)
                {
                    est.idUsuariResponsable = Int32.Parse(Usuaris.SelectedValue.ToString());
                    est.idEstatEstabulacio = 2;
                    est.idInspeccioSanitaria = 1;
                    est.numEstable = NumEstable.Text;
                    est.dataEntrada = DateTime.ParseExact(DiaEntrada.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    est.Incidencies = incidencia;
                    MessageBox.Show("Inserit Correctament");

                }
                else
                {
                    est.idUsuariResponsable = Int32.Parse(Usuaris.SelectedValue.ToString());
                    est.idEstatEstabulacio = 3;
                    est.dataSortida = DateTime.ParseExact(DiaSortida.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    est.Incidencies = incidencia;
                }

                _m.SaveChanges();
                ActualitzarDataGrid();
            }
        }
        private void finalitzarProces()
        {
            using (escorxadam2Entities enti = new escorxadam2Entities())
            {
                var sac = new sacrificis
                {
                    idUsuari = 1,
                    idSistemaAtordiment = 1,
                    idInspeccioSanitaria = 1,
                    idEstatSacrifici = 1,
                    Incidencies = "Cap incidencia",
                };
                _m.sacrificis.Add(sac);
                _m.SaveChanges();
                var lotes = _m.lots.OrderByDescending(u => u.numLot == Lots.Text).FirstOrDefault();
                long idsacrifici  = (from a in _m.sacrificis
                                    select a.idSacrifici).Max();

                lotes.idSacrifici = idsacrifici;
                _m.SaveChanges();
            }
            MessageBox.Show("Finalitzat");
        }
    }
}