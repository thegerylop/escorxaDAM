using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            progressBarSplash.Increment(2);
            if(progressBarSplash.Value == 100)
            {
                timerSplash.Stop();
                Form frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
