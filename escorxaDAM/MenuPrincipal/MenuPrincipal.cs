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

namespace MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        string[] acces;
        public void menuAcces(string[] value)
        {
            acces = value;
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
            string nivells = "";
            int count = 0;
            foreach (string item in acces)
            {
                count++;
                if(count == acces.Length)
                {
                    nivells += item + "%'";
                } else
                {
                    nivells += item + "%' OR `nivellAcces` like '%";
                }
                
            }
            string query = "select * from itemMenu where `nivellAcces` like '%" + nivells;
            DataSet menu = conn.portarPerConsulta(query, "menu");
            DataTable dt = menu.Tables[0];
            ToolStripMenuItem mt = new ToolStripMenuItem();

            foreach(DataRow row in dt.Rows)
            {
                CustomControl.menuItem item = new CustomControl.menuItem();
                item.Font = new Font("Segoe UI", 11f);
                item.Text = Convert.ToString(row["nomItem"]);
                item.Dll = Convert.ToString(row["dll"]);
                item.Taula = Convert.ToString(row["taula"]);
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
            if (!Metodes.IsOpen(form.Name))
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Focus();
            }
            //form.BringToFront();
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
