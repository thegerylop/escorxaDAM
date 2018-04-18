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
using BaseForm;
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
            CCLogin.Text = "admin";
            CCPassword.Text = "admin";
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
                this.Hide();
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
                Application.Exit();
            }
        }
    }
}
