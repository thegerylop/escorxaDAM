using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstatInspeccio
{
    public partial class estatInspeccio : BaseForm.BaseForm
    {
        public estatInspeccio()
        {
            InitializeComponent();
        }

        string table = "estat_inspeccions";

        private void estatInspeccio_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idEstatInspeccio"].Visible = false;
        }
    }
}
