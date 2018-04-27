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
        public string AccesoInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return "";
            }
            catch (Exception es)
            {
                string message = "No hi ha conexió a internet";
                return message;
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
