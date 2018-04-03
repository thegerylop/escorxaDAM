using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paisos
{
    public partial class Paisos : BaseForm.BaseForm
    {
        public Paisos()
        {
            InitializeComponent();
        }

        string table = "paisos";

        private void Paisos_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idPais"].Visible = false;
        }
    }
}
