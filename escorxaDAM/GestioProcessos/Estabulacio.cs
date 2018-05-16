using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestioProcessos
{
    public partial class Estabulacio : BaseForm.BaseInserir
    {

        escorxadam2Entities _m = new escorxadam2Entities();

        public Estabulacio()
        {
            InitializeComponent();
        }

        private void Estabulacio_Load(object sender, EventArgs e)
        {
            ActualitzarDataGrid();
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

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void estabulacioDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if()
        }
    }
}
