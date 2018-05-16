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
    public partial class Processat_Inicial : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();

        public Processat_Inicial()
        {
            InitializeComponent();
        }

        private void Processat_Inicial_Load(object sender, EventArgs e)
        {
            
            updateGrid();
        }

        private void updateGrid()
        {
            //Agafo les dades
            var dades = (from a in _m.estat_processos_inicials
                         join b in _m.lots on a.idEstatProcesInicial equals b.idProcessatInicial
                         select new { a.Estat, b.numLot }).ToArray();
            //Fico les dades
            AnimalsGrid.DataSource = dades; 
        }
    }
}
