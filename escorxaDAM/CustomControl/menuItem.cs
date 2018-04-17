using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class menuItem : ToolStripMenuItem
    {
        String _dll;
        public String Dll
        {
            get
            {
                return _dll;
            }
            set
            {
                _dll = value;
            }
        }

        String _taula;
        public String Taula
        {
            get
            {
                return _taula;
            }
            set
            {
                _taula = value;
            }
        }
    }
}
