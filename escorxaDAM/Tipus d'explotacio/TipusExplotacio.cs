using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tipus_d_explotacio
{
    public partial class TipusExplotacio : BaseForm.BaseForm
    {
        public TipusExplotacio()
        {
            InitializeComponent();
        }

        string table = "tipus_explotacions";

        private void TipusExplotacio_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idTipusExplotacio"].Visible = false;
        }
    }
}
