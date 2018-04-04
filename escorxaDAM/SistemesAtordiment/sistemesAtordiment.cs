using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemesAtordiment
{
    public partial class sistemesAtordiment : BaseForm.BaseForm
    {
        public sistemesAtordiment()
        {
            InitializeComponent();
        }

        string table = "sistemes_atordiment";

        private void sistemesAtordiment_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idSistemaAtordiment"].Visible = false;
        }
    }
}
