using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuracio
{
    public partial class configuracio : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        public configuracio()
        {
            InitializeComponent();
        }

        private void configuracio_Load(object sender, EventArgs e)
        {
        }

        private void paisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Paisos.Paisos frm = new Paisos.Paisos();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
