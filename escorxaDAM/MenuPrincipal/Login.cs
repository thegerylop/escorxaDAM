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

        private void button1_Click(object sender, EventArgs e)
        {
            string login = CCLogin.Text;
            string password = CCPassword.Text;
            Boolean acces;
            //BINARY
            string comanda = "SELECT codiUsuari, password FROM usuaris WHERE codiUsuari = '" + login + "' and password = '" + password + "'";
            acces = conn.executaComanda(comanda);
            if(acces)
            {
                Form frm = new MenuPrincipal();
                this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuari o contrasenya incorrecta");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            CCLogin.Text = "Usuari";
            CCPassword.Text = "Contrasenya";
        }
    }
}
