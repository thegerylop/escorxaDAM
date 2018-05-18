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
            var dades = (from proc_inicial in _m.processats_inicials
                         join lots in _m.lots on proc_inicial.idEstatInicial equals lots.idProcessatInicial
                         join estats in _m.estat_processos_inicials on proc_inicial.idEstatInicial equals estats.idEstatProcesInicial
                         
                         where (estats.Estat == "En espera" || estats.Estat == "En procés")
                         select new { estats.Estat, lots.numLot }).ToArray();

            //Fico les dades
            AnimalsGrid.DataSource = dades; 
        }

        private void AnimalsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;

            txtBoxEstat.Text = AnimalsGrid.Rows[num].Cells[0].Value.ToString();
            string Nlot = AnimalsGrid.Rows[num].Cells[1].Value.ToString();
            txtNLot.Text = Nlot;
            txtBoxDIB.Text = getDIBAnimal(Nlot);
        }

        private string getDIBAnimal(string numLot)
        {

            //Agafo el DNI del animal
            var dades = (from l in _m.lots
                         join rb in _m.recepcions_bestiar on l.idRemo equals rb.idRecepcio
                         join a in _m.animals on rb.idRecepcio equals a.idRecepcioBestiar
                         where (l.numLot == numLot)
                         select new { a.DIB }).ToArray();
            string result = dades[0].ToString();
            MessageBox.Show(result);
            return result ;
        }
    }
}
