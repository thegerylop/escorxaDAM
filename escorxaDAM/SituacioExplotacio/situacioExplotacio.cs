using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SituacioExplotacio
{
    public partial class situacioExplotacio : BaseForm.BaseForm
    {
        public situacioExplotacio()
        {
            InitializeComponent();
        }

        string table = "situacio_explotacions";

        private void situacioExplotacio_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idSituacioExplotacio"].Visible = false;
        }
    }
}
