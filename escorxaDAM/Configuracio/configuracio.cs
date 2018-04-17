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

        private void estatEnvasatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EstatProcesEnvasat.estatProcesEnvasat frm = new EstatProcesEnvasat.estatProcesEnvasat();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void estatDeLaInspeccióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EstatInspeccio.estatInspeccio frm = new EstatInspeccio.estatInspeccio();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void provasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ComunitatsAutonomes.ComunitatsAutonomes frm = new ComunitatsAutonomes.ComunitatsAutonomes();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tipusDexplotacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Tipus_d_explotacio.TipusExplotacio frm = new Tipus_d_explotacio.TipusExplotacio();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void situacióDexplotacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SituacioExplotacio.situacioExplotacio frm = new SituacioExplotacio.situacioExplotacio();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void sistemesDatordimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SistemesAtordiment.sistemesAtordiment frm = new SistemesAtordiment.sistemesAtordiment();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void estatDelProcésDeRefrigeracióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EstatProcesRefrigeracio.estatProcesRefrigeracio frm = new EstatProcesRefrigeracio.estatProcesRefrigeracio();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void lotsmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ComptadorsLotsMs.comptadorsLotsMes frm = new ComptadorsLotsMs.comptadorsLotsMes();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void referènciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Referencies.referencies frm = new Referencies.referencies();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
