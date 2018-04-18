using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm
{
    public class Metodes
    {
        public static bool IsOpen(string nameForm)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(nameForm))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
