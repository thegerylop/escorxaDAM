using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstatProcesEnvasat
{
    public partial class estatProcesEnvasat : BaseForm.BaseForm
    {
        public estatProcesEnvasat()
        {
            InitializeComponent();
        }

        string table = "estat_processos_envasat";

        private void estatProcesEnvasat_Load(object sender, EventArgs e)
        {
            Table(table);
            amagarCamps();
        }

        private void amagarCamps()
        {
            this.dgvBase.Columns["idEstatProcesEnvasat"].Visible = false;
        }
    }
}
