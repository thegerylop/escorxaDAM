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
                       where (c.nomEstatRefrigeracio == "En espera" || c.nomEstatRefrigeracio == "En procés")
                       select new { a.lots, c.nomEstatRefrigeracio, a.numCambraFrigorifica, b.codiUsuari, a.dataEntrada, });

            dgwEmmagatzematge.DataSource = num;
        }
    }
}
