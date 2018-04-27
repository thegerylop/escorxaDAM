using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClassHelpers
{
    public class FTPhelper
    {
        public bool AccesoInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (Exception es)
            {
                return false;
            }
        }

        public string[] getCredentials()
        {
            string[] credentials = new string[2];
            credentials[0] = ConfigurationManager.ConnectionStrings["FTPuser"].ConnectionString;
            credentials[1] = ConfigurationManager.ConnectionStrings["FTPpassword"].ConnectionString;
            return credentials;
        }
    }
}
