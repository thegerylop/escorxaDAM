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
        }
        private void omplirCampsProces()
        {

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            NumEstable.Text = rnd.Next(1, 11).ToString();
            DiaEntrada.Text = DateTime.Now.ToString("yyy/MM/dd HH:mm");
            afegirBBDD();
        }

        private void btnFinalitzar_Click(object sender, EventArgs e)
        {

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
            using (escorxadam2Entities test = new escorxadam2Entities())
            {
                var estabulacio = new estables
                {
                    idUsuariResponsable = Int32.Parse(Usuaris.SelectedValue.ToString()),
                    idEstatEstabulacio = 1,
                    idInspeccioSanitaria = 1,
                    numEstable = NumEstable.Text,
                    dataEntrada = DateTime.ParseExact(DiaEntrada.Text, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
                    Incidencies = incidencia,
                };
                _m.estables.Add(estabulacio);
                _m.SaveChanges();

                int idEstable = Int32.Parse(_m.estables.Max(u => u.idEstable).ToString());
                var lots = _m.lots.SingleOrDefault(a => a.numLot == lot);

                lots.idEstabulacio = idEstable;
                _m.SaveChanges();

                ActualitzarDataGrid();
            }
        }
    }
}