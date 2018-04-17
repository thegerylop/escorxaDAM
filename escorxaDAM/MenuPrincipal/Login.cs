using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexioBBDD;
namespace MenuPrincipal
{
    public partial class Login : Form
    {
        Conexio conn = new Conexio();
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            CCLogin.Select();
            CCLogin.Text = "Usuari";
            CCPassword.Text = "Contrasenya";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string command = "SELECT idUsuari FROM usuaris where Nom = '" + CCLogin.Text + "' and password = '" + CCPassword.Text + "'";
            //BINARY
            string idUsuari = conn.resultatComanda(command);
            string commandAcces = "SELECT `idNivellAcces` FROM `permisos` WHERE `idUsuari`= " + idUsuari;
            if(idUsuari != "")
            {
                string[] nivellAcces = conn.resultatComandaArray(commandAcces);
                MenuPrincipal frm = new MenuPrincipal();
                frm.menuAcces(nivellAcces);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuari o contrasenya incorrecta");
            }
        }

        private void CCLogin_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void CCPassword_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (!IsOpen("MenuPrincipal"))
                {
                    Application.Exit();
                }
            }
        }

        public static bool IsOpen(string nameForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals(nameForm))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
