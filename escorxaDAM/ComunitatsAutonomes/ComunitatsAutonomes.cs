using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComunitatsAutonomes
{
    public partial class ComunitatsAutonomes : BaseForm.BaseForm
    {
        public ComunitatsAutonomes()
        {
            InitializeComponent();
        }

        string table = "comunitats_autonomes";

        private void ComunitatsAutonomes_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idComunitatAutonoma"].Visible = false;
        }
    }
}
