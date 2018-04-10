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
        string[] acces;
        public void menuAcces(string[] value)
        {
            acces = value;
        }
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

        private void estatDeLaInspeccióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatInspeccio.estatInspeccio frm = new EstatInspeccio.estatInspeccio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void païsosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paisos.Paisos frm = new Paisos.Paisos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipusDexplotacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipus_d_explotacio.TipusExplotacio frm = new Tipus_d_explotacio.TipusExplotacio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void situacióDexplotacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SituacioExplotacio.situacioExplotacio frm = new SituacioExplotacio.situacioExplotacio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sistemesDatordimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemesAtordiment.sistemesAtordiment frm = new SistemesAtordiment.sistemesAtordiment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estatDelProcésDeRefrigeracióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatProcesRefrigeracio.estatProcesRefrigeracio frm = new EstatProcesRefrigeracio.estatProcesRefrigeracio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estatDelProcésDenvasatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatProcesEnvasat.estatProcesEnvasat frm = new EstatProcesEnvasat.estatProcesEnvasat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comptadorsDeLotsmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComptadorsLotsMs.comptadorsLotsMes frm = new ComptadorsLotsMs.comptadorsLotsMes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void referènciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Referencies.referencies frm = new Referencies.referencies();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            accesMenu();
        }
        private void accesMenu()
        {
            foreach(string element in acces)
            {
                if(element.Equals("1"))
                {
                    mantenimentDusuarisToolStripMenuItem.Visible = true;
                    registreProveïdorsToolStripMenuItem.Visible = true;
                    dadesEmpresaToolStripMenuItem.Visible = true;
                    fitxersAuxiliarsToolStripMenuItem.Visible = true;
                }
                if(element.Equals("2"))
                {
                    gestióDeProcessosToolStripMenuItem.Visible = true;
                    recepcióBestiarToolStripMenuItem.Visible = true;
                }
                if(element.Equals("3"))
                {
                    gestióDeProcessosToolStripMenuItem.Visible = true;
                    estabulacióToolStripMenuItem.Visible = true;
                }
                if(element.Equals("4"))
                {
                    gestióDeProcessosToolStripMenuItem.Visible = true;
                    sacrificiToolStripMenuItem.Visible = true;
                }
                if(element.Equals("5"))
                {
                    gestióDeProcessosToolStripMenuItem.Visible = true;
                    emmagatzematgeToolStripMenuItem.Visible = true;
                }
                if(element.Equals("6"))
                {
                    gestióDeProcessosToolStripMenuItem.Visible = true;
                    processatFinalToolStripMenuItem.Visible = true;
                }
            }
        }
    }
}
