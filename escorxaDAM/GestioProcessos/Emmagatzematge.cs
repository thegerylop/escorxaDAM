using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;
using Models;
using ClassHelpers;

namespace GestioProcessos
{
    public partial class Emmagatzematge : BaseInserir
    {
        escorxadam2Entities _m = new escorxadam2Entities();
        ClassHelpers.EDI_TCPhelpers edi = new ClassHelpers.EDI_TCPhelpers();
        public Emmagatzematge()
        {
            InitializeComponent();
        }
        private void Emmagatzematge_Load(object sender, EventArgs e)
        {
            var num = (from a in _m.emmagatzematges
                       join b in _m.usuaris on a.idUsuariEntrada equals b.idUsuari
                       join c in _m.estat_refrigeracions on a.idEstatRefrigeracio equals c.idEstatRefrigeracio
                       join d in _m.lots on a.idEmmagatzematge equals d.idEmmagatzematge
                       where (c.nomEstatRefrigeracio == "En espera" || c.nomEstatRefrigeracio == "En procés")
                       select new { d.numLot, c.nomEstatRefrigeracio, a.numCambraFrigorifica, b.codiUsuari, a.dataEntrada });

            dgwEmmagatzematge.DataSource = num;
        }

        private void dgwEmmagatzematge_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carreguem els camps que sempre volem veure amb un lot seleccionat
            lblLot.Show();
            txtLot.Show();
            lblEstat.Show();
            txtEstat.Show();
            lblNumero.Show();
            txtNumCamFrigo.Show();

            //Agafem els valors del registre i omplim les textbox corresponents
            int num = e.RowIndex;
            txtLot.Text = dgwEmmagatzematge.Rows[num].Cells[0].Value.ToString();
            txtEstat.Text = dgwEmmagatzematge.Rows[num].Cells[1].Value.ToString();

            //Si l'estat és 'En procés', mostrem més opcions. Sinó, les amaguem
            //if ()
            //{
            //    lblUserIn.Show();
            //    txtUserIn.Show();
            //    lblDataIn.Show();
            //    dateIn.Show();
            //}
            //else
            //{
            //    lblUserIn.Hide();
            //    txtUserIn.Hide();
            //    lblDataIn.Hide();
            //    dateIn.Hide();
            //    dateIn.Show();
            //    gbxNevera.Hide();
            //}
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Mostrem camps d'usuari d'entrada i data d'entrada
            lblUserIn.Show();
            txtUserIn.Show();
            lblDataIn.Show();
            dateIn.Show();
            
            //Llegim user i data
            //txtUserIn = user.ToString();
            //dateIn = avui;

            //Canviem l'estat de la refrigeració
        }

        private void btnTreure_Click(object sender, EventArgs e)
        {
            gbxNevera.Show();

            string info = dateIn.Text + '-' + dateOut.Text;
            string ip = "127.0.0.1";
            int port = 8000;

            string temps = EDI_TCPhelpers.sendUDPData(ip, port, info);

            int change = temps.IndexOf("-");
            string tempMin = temps.Substring(0, change);
            string tempMax = temps.Substring(change + 1);

            txtMinTemp.Text = tempMin;
            txtMaxTemp.Text = tempMax;

            int tempMinima = Int32.Parse(tempMin);
            int tempMaxima = Int32.Parse(tempMax);

            int diferenciaHora = 6;

            if (tempMinima < 2 || tempMaxima > 5 || diferenciaHora < 6 )
            {
                txtEstat.Text = "Defectuós";
            } else
            {
                txtEstat.Text = "Correcte";
            }
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            //Tornem a fer la select per carregar-ho tot
            //var num = (from a in _m.emmagatzematges
            //           join b in _m.usuaris on a.idUsuariEntrada equals b.idUsuari
            //           join c in _m.estat_refrigeracions on a.idEstatRefrigeracio equals c.idEstatRefrigeracio
            //           join d in _m.lots on a.idEmmagatzematge equals d.idEmmagatzematge
            //           where (c.nomEstatRefrigeracio == "En espera" || c.nomEstatRefrigeracio == "En procés")
            //           select new { d.numLot, c.nomEstatRefrigeracio, a.numCambraFrigorifica, b.codiUsuari, a.dataEntrada });

            //dgwEmmagatzematge.DataSource = num;
        }
    }
}
