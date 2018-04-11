using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
            progressBarSplash.Increment(3);
            if(progressBarSplash.Value == 100)
            {
                timerSplash.Stop();
                Form frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void Splash_Load_1(object sender, EventArgs e)
        {
            
            string Directorio = Application.StartupPath + "\\MenuPrincipal.exe";
            string provider = "DataProtectionConfigurationProvider";
            System.Configuration.Configuration configuration = null;
            System.Configuration.ConnectionStringsSection section = null;
            try
            {
                configuration = ConfigurationManager.OpenExeConfiguration(Directorio);
                if(configuration != null)
                {
                    bool changed = false;
                    section = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
                    if(section != null)
                    {
                        if((!(section.ElementInformation.IsLocked)) & (!(section.SectionInformation.IsLocked)))
                        {
                            if(!(section.SectionInformation.IsProtected))
                            {
                                changed = true;
                                section.SectionInformation.ProtectSection(provider);
                            }
                        }

                        if(changed)
                        {
                            section.SectionInformation.ForceSave = true;
                            configuration.Save();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
