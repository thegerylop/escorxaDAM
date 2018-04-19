using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;


namespace ConexioBBDD
{
    public class Conexio
    {

        string connString;

        SqlConnection conn = new SqlConnection();
        public void connexio()
        {
            connString = PortaCadenaConnexio();
            conn = new SqlConnection(connString);
            conn.Open();
            conn.InitializeLifetimeService();
        }
        public string PortaCadenaConnexio()
        {
            string cadena = ConfigurationManager.ConnectionStrings["escorxaDAM"].ConnectionString;
            return cadena;
        }

        public Boolean executaComanda(string comanda)
        {
            try
            {
                connexio();
                SqlCommand command = new SqlCommand(comanda, conn);
                var result = command.ExecuteScalar();
                if(result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(SqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public String resultatComanda(string comanda)
        {
            try
            {
                connexio();
                SqlCommand command = new SqlCommand(comanda, conn);

                using(SqlDataReader dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        string resultat = dr[0].ToString();
                        return resultat;
                    }
                }
                return "";
            }
            catch(SqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
                return "";
            }
            finally
            {
                conn.Close();
            }

        }

        public String[] resultatComandaArray(string comanda)
        {
            List<string> list = new List<string>();
            try
            {
                connexio();
                SqlCommand command = new SqlCommand(comanda, conn);

                using(SqlDataReader dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        list.Add(dr.GetInt64(0).ToString());

                    }
                    return list.ToArray();
                }
                return list.ToArray();
            }
            catch(SqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
                return list.ToArray();
            }
            finally
            {
                conn.Close();
            }

        }

        public bool Actualitzar(String query, String taula, DataSet dtsAct)
        {
            bool correcte = true;

            SqlDataAdapter dtaDepart;
            SqlCommandBuilder construct;

            try
            {
                connexio();

                dtaDepart = new SqlDataAdapter(query, conn);
                construct = new SqlCommandBuilder(dtaDepart);

                if(dtsAct.HasChanges())
                {
                    dtaDepart.Update(dtsAct, taula);
                }
            }
            catch(SqlException e)
            {
                correcte = false;
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return correcte;
        }

        public int executaSQL(String cmd)
        {
            connexio();

            SqlCommand cmdQry = new SqlCommand(cmd, conn);

            return cmdQry.ExecuteNonQuery();

        }

        public DataTable searchTableFromQuery(string query2)
        {
            SqlDataAdapter dtaDades = new SqlDataAdapter();
            SqlCommandBuilder construct = new SqlCommandBuilder();
            DataSet dtsDades = new DataSet();
            DataTable dt = null;
            try
            {
                connexio();
                dtaDades = new SqlDataAdapter(query2, conn);
                construct = new SqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dt = new DataTable();
                dtaDades.Fill(dt);


            }
            catch(SqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return dt;
        }
        public DataSet portarPerConsulta(String query, String table)
        {
            SqlDataAdapter dtaDades = new SqlDataAdapter();
            SqlCommandBuilder construct = new SqlCommandBuilder();
            DataSet dtsDades = new DataSet();

            try
            {
                connexio();
                dtaDades = new SqlDataAdapter(query, conn);
                construct = new SqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dtaDades.Fill(dtsDades, table);


            }
            catch(SqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return dtsDades;
        }

    }
}