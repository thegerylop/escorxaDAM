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
    public partial class Processat_Final : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();

        string lot;
        double pes;
        public Processat_Final()
        {
            InitializeComponent();
        }

        private void Processat_Final_Load(object sender, EventArgs e)
        {
            updateGrid();
            // obtenirUsuaris();
            // obtenirSistemas();
        }
        private void updateGrid()
        {
            //Agafo les dades
            var dades = (from procFinal in _m.processats_finals
                         join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                         join recepcio in _m.recepcions_bestiar on lots.idRemo equals recepcio.idRecepcio
                         select new { lots.numLot }).ToArray();
            //Fico les dades
            SafataGrid.DataSource = dades;
        }

        private void SafataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dadesDataGrid(e);
            omplirCampsComuns();
        }
        private void omplirCampsComuns()
        {
            txtBoxLot.Text = lot;
            txtBoxPes.Text = pes.ToString();
        }
        private void dadesDataGrid(DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            lot = SafataGrid.Rows[num].Cells[0].Value.ToString();
            pes = 0;
            var dades = (from procFinal in _m.processats_finals
                         join lots in _m.lots on procFinal.idProcessatFinal equals lots.idProcessatFinal
                         join recepcio in _m.recepcions_bestiar on lots.idRemo equals recepcio.idRecepcio
                         join anim in _m.animals on recepcio.idRecepcio equals anim.idRecepcioBestiar
                         where lots.numLot == lot
                         select anim.Pes).ToArray();
            foreach(double item in dades)
            {
                pes += item;
            }
        }
    }
}
