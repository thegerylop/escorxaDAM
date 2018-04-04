using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Referencies
{
    public partial class referencies : BaseForm.BaseForm
    {
        public referencies()
        {
            InitializeComponent();
        }
        string table = "referencies";
        private void referencies_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idReferencia"].Visible = false;
        }
    }
}
