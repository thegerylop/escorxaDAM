using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantenimentUsuaris
{
    public partial class MantenimentUsuaris : BaseForm.BaseModificar
    {
        public MantenimentUsuaris()
        {
            InitializeComponent();
        }
        string table = "usuaris";

        private void MantenimentUsuaris_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idUsuari"].Visible = false;
            this.dgvBase.Columns["actiu"].Visible = false;
            idUsuari.Visible = false;
        }
    }
}
