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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void afegirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimentUsuaris.AfegirUsuari frm = new MantenimentUsuaris.AfegirUsuari();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimentUsuaris.MantenimentUsuaris frm = new MantenimentUsuaris.MantenimentUsuaris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void emmagatzematgeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comunitatsAutònomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComunitatsAutonomes.ComunitatsAutonomes frm = new ComunitatsAutonomes.ComunitatsAutonomes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }
    }
}
