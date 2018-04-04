using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstatProcesRefrigeracio
{
    public partial class estatProcesRefrigeracio : BaseForm.BaseForm
    {
        public estatProcesRefrigeracio()
        {
            InitializeComponent();
        }

        string table = "estat_refrigeracions";

        private void estatProcesRefrigeracio_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idEstatRefrigeracio"].Visible = false;
        }
    }
}
