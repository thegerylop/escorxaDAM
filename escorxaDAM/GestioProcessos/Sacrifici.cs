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

namespace GestioProcessos
{
    public partial class Sacrifici : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
          
        public Sacrifici()
        {
            InitializeComponent();
        }

        private void gridAnimals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;

            txtBoxEstat.Text = gridAnimals.Rows[num].Cells[0].Value.ToString();
            txtBoxNLot.Text = gridAnimals.Rows[num].Cells[1].Value.ToString();

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

        private void Sacrifici_Load(object sender, EventArgs e)
        {
            updateGrid();
        }
    }
}
