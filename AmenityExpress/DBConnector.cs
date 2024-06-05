using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AmenityExpress
{
    internal static class DBConnector
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private static KeyValueConfigurationCollection settings = config.AppSettings.Settings;
        private static string connstr= connstr = "data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = " + settings["host"].Value + ")(PORT = " + settings["port"].Value + ")))(CONNECT_DATA =(SERVICE_NAME = " + settings["sid"].Value + ")));USER ID=" + settings["id"].Value + ";PASSWORD=" + settings["pwd"].Value + ";";
        private static OracleConnection conn = new OracleConnection(connstr);
        private static OracleCommand cmd = new OracleCommand();

        public static void DML_NON_QUERY(string sql, OracleParameter[] parameters) //insert, delete, update
        {
            cmd.Connection = conn;
            cmd.CommandText = sql;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); //반환값 x ==>void
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
        }
        public static DataSet DML_QUERY(string sql, OracleParameter[] parameters) //select문 쓸 때
        {
            cmd.Connection = conn;
            cmd.CommandText = sql;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                using (OracleDataAdapter reader = new OracleDataAdapter(cmd))
                {
                    reader.Fill(ds);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
            return ds;
        }
    }
}
