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
    public partial class Sacrifici : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        string lot;
        string estat;

        public Sacrifici()
        {
            InitializeComponent();
        }

        private void gridAnimals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dadesDataGrid(e);
            omplirCampsComuns();
            if (estat.Equals("En espera"))
            {
                btnInserir.Visible = true;
            }
            else
            {
                btnFinalitzar.Visible = true;
                omplirCampsProces();

            }


        }
        private void omplirCampsComuns()
        {
            txtBoxNLot.Text = lot;
            txtBoxEstat.Text = estat;
        }
        private void dadesDataGrid(DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            lot = gridAnimals.Rows[num].Cells[0].Value.ToString();
            estat = gridAnimals.Rows[num].Cells[1].Value.ToString();
        }
        private void omplirCampsEspera()
        {
            Random rnd = new Random();
            txtBoxBox.Text = rnd.Next(1, 11).ToString();
            dataSacrifici.Text = DateTime.Now.ToString("yyy/MM/dd");
        }
        private void omplirCampsProces()
        {
            var sacr = (from a in _m.lots
                           join b in _m.sacrificis on a.idSacrifici equals b.idSacrifici
                           where a.numLot == lot
                           select b).FirstOrDefault();
            txtBoxBox.Text = sacr.AparellAtordiment;
            cBoxAtordiment.SelectedValue = sacr.idSistemaAtordiment;
            txtBoxIncidencies.Text = sacr.Incidencies;
            Usuaris.SelectedValue = sacr.idUsuari;
            dataSacrifici.Text = sacr.dataSacrifici.ToString();
        }


        private void Sacrifici_Load(object sender, EventArgs e)
        {
            updateGrid();
            obtenirUsuaris();
            obtenirSistemas();
        }
        private void updateGrid()
        {
            //Agafo les dades
            var dades = (from sacrifici in _m.sacrificis
                         join lots in _m.lots on sacrifici.idSacrifici equals lots.idSacrifici
                         join estats in _m.estat_sacrifici on sacrifici.idEstatSacrifici equals estats.idEstatSacrifici

                         where (estats.nomEstatSacrifici == "En espera" || estats.nomEstatSacrifici == "En procés")
                         select new { lots.numLot, estats.nomEstatSacrifici }).ToArray();

            //Fico les dades
            gridAnimals.DataSource = dades;
        }
        public void obtenirUsuaris()
        {
            var usuaris = (from a in _m.usuaris
                           select new { a.idUsuari, a.Nom }).ToArray();
            Usuaris.DataSource = usuaris;
            Usuaris.DisplayMember = "Nom";
            Usuaris.ValueMember = "idUsuari";
        }

        public void obtenirSistemas()
        {
            var sistemas = (from a in _m.sistemes_atordiment
                           select new { a.idSistemaAtordiment, a.nomSistemaAtordiment }).ToArray();
            cBoxAtordiment.DataSource = sistemas;
            cBoxAtordiment.DisplayMember = "nomSistemaAtordiment";
            cBoxAtordiment.ValueMember = "idSistemaAtordiment";
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            omplirCampsEspera();
            afegirBBDD();
        }
        private void afegirBBDD()
        {
            string incidencia;
            if (txtBoxIncidencies.Text == "")
            {
                incidencia = "Cap incidencia";
            }
            else
            {
                incidencia = txtBoxIncidencies.Text;
            }
            using (escorxadam2Entities test = new escorxadam2Entities())
            {
                string idSacrifici = (from a in _m.lots
                                where a.numLot.ToString() == txtBoxNLot.Text
                                select a.idSacrifici).First().ToString();
                var sacrifici = (from a in _m.sacrificis
                           where a.idSacrifici.ToString() == idSacrifici
                           select a).FirstOrDefault();

                if (sacrifici.idEstatSacrifici == 1)
                {
                    sacrifici.idUsuari = Int32.Parse(Usuaris.SelectedValue.ToString());
                    sacrifici.idSistemaAtordiment = Int32.Parse(cBoxAtordiment.SelectedValue.ToString());
                    sacrifici.AparellAtordiment = cBoxAtordiment.SelectedText.ToString();
                    sacrifici.idEstatSacrifici = 2;
                    sacrifici.idInspeccioSanitaria = 1;
                    sacrifici.boxImmobilitzacio = txtBoxBox.Text;
                    sacrifici.dataSacrifici = DateTime.ParseExact(dataSacrifici.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    sacrifici.Incidencies = incidencia;

                }
                else
                {
                    sacrifici.idUsuari = Int32.Parse(Usuaris.SelectedValue.ToString());
                    sacrifici.idEstatSacrifici = 3;
                    sacrifici.Incidencies = incidencia;
                }

                _m.SaveChanges();
                updateGrid();
            }
        }
        private void btnFinalitzar_Click(object sender, EventArgs e)
        {
            afegirBBDD();
            finalitzarProces();
        }
        private void finalitzarProces()
        {

        }

        private void cBoxAtordiment_TextChanged(object sender, EventArgs e)
        {
            txtBoxAparell.Text = cBoxAtordiment.SelectedValue.ToString();
        }
    }
}
