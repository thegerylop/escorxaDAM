using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComptadorsLotsMs
{
    public partial class comptadorsLotsMes : BaseForm.BaseForm
    {
        public comptadorsLotsMes()
        {
            InitializeComponent();
        }

        string table = "comptadors_lot_mes";

        private void comptadorsLotsMes_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idComptadorLotMes"].Visible = false;
        }
    }
}
