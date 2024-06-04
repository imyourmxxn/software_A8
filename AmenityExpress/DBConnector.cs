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
    internal class DBConnector
    {

        private static string connstr;
        private static OracleConnection conn;
        private static OracleCommand cmd = new OracleCommand();
        public DBConnector()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var settings = config.AppSettings.Settings;
            connstr = "data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = " + settings["host"].Value + ")(PORT = " + settings["port"].Value + ")))(CONNECT_DATA =(SERVICE_NAME = " + settings["sid"].Value + ")));USER ID=" + settings["id"].Value + ";PASSWORD=" + settings["pwd"].Value + ";";
            conn = new OracleConnection(connstr);
        }

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
                conn.Close();
            }
            return ds;
        }
        public void DML_NON_QUERY(string sql, OracleParameter[] parameters) // DB에 클래스 단위로 정보를 삽입하는 함수
        {
            using (var conn = new OracleConnection(connstr))
            using (var cmd = new OracleCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
    }
}
