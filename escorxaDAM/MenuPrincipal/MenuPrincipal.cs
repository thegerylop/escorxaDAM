using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        BaseForm.BaseForm Base = new BaseForm.BaseForm();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void nivellsDaccésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Base.MdiParent = this;
            Base.Dock = DockStyle.Fill;
            Base.Show();
        }
    }
}
