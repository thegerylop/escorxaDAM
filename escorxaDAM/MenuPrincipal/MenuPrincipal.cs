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
using BaseForm;
using Models;
namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();

        long user;
        public void menuAcces(long value)
        {
            user = value;
        }
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            accesMenu();
        }
        private void accesMenu()
        {
            var userAcces = from a in _m.permisos
                          where a.idUsuari == user
                          select a.idNivellAcces;


            var menuStrip = from a in _m.itemMenu
                            where userAcces.Any(item => a.nivellAcces.Contains(item.ToString()))
                            select a;


            foreach (Models.itemMenu items in menuStrip)
            {
                CustomControl.menuItem item = new CustomControl.menuItem();
                item.Font = new Font("Segoe UI", 11f);
                item.Text = items.nomItem;
                item.Dll = items.dll;
                item.Taula = items.taula;
                item.Click += new EventHandler(itemForm);
                menuStrip1.Items.Add(item);
            }

        }
        public void itemForm(object sender, EventArgs e)
        {
            string name = ((CustomControl.menuItem)sender).Dll+"."+((CustomControl.menuItem)sender).Taula;
            var dllFile = new FileInfo(((CustomControl.menuItem)sender).Dll);
            Assembly assembly = Assembly.LoadFile(dllFile.FullName+".dll");
            Type type = assembly.GetType(name);
            Form form = (Form)Activator.CreateInstance(type);
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }
        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercDe frm = new AcercDe();
            if (!Metodes.IsOpen("AcercDe"))
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        private void tancarSessióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Metodes.IsOpen("AcercDe"))
            {
                Application.OpenForms.OfType<AcercDe>().First().Close();
            }
            Login frm = new Login();
            frm.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
