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
using Models;
namespace MenuPrincipal
{
    public partial class Login : Form
    {
        Conexio conn = new Conexio();
        public Login()
        {
            InitializeComponent();
        }
        private void loginEF()
        {
            escorxadam2Entities _m = new escorxadam2Entities();
            //user Object
            var myUser = _m.usuaris
            .FirstOrDefault(u => u.Nom == CCLogin.Text
                     && u.password == CCPassword.Text);
            //var query = hacerla
            // permisos.ToList();
            
            if (myUser != null)
            {
                string commandAcces = "SELECT idNivellAcces FROM permisos WHERE idUsuari= " + myUser.idUsuari;
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
            permisos p = new permisos();
            p.idUsuari = 1233;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            CCLogin.Select();
            CCLogin.Text = "admin";
            CCPassword.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginEF();
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
