using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace Sitran
{
    /// <summary>
    /// Comprueba que el código REGA existe en la tabla SITRAN
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SitranWS : System.Web.Services.WebService
    {
        //Abrir conexión contra la base de datos SQL
        SqlConnection conn = new SqlConnection();
        DataSet dts = new DataSet();

        private static string _host = "den1.mssql4.gear.host";
        private static string _UID = "escorxadam2";
        private static string _password = "Ag69!J031s1?";
        private static string _dataBase = "escorxadam2";
        //private static string _port = "";

        public static string connectionString = $"Server={_host};Database={_dataBase};User Id={_UID};Password={_password};";//DATABASE={_dataBase};";

        [WebMethod]

        //Verifica que el código REGA es correcto
        public bool CheckREGA(string rega)
        {
            bool check = false;
            string table = "sitran";
            string query = "Select distinct * from " + table + " where codiRega = " + rega;

            connectaBD();
            dts = portaDades(query, table);
            try
            {
                int rows = dts.Tables[table].Rows.Count;
                if (rows == 1)
                {
                    if ((dts.Tables[table].Rows[0][4].ToString() == "Boví") && (dts.Tables[table].Rows[0][3].ToString() == "Activa"))
                    {
                        if ((dts.Tables[table].Rows[0][2].ToString() == "Centre de producció") || (dts.Tables[table].Rows[0][2].ToString() == "Tractants de bestiar"))
                        {
                            check = true;
                        }
                    }
                }
            }
            catch
            {
                NullReferenceException eNull;
            }
            return check;
        }

        public void connectaBD()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        public DataSet portaDades(string query, string table)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(query);
                connectaBD();
                SqlDataAdapter dtaWS = default(SqlDataAdapter);
                DataSet dtsWS = new DataSet();
                dtaWS = new SqlDataAdapter(query, conn);
                dtaWS.Fill(dts, table);
                return dts;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
