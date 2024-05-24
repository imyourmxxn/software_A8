using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HotelRequest
{
    internal class DBConnector
    {

        private const string connstr = "data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = gyeongmin2022.kro.kr)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = orcl)));USER ID=admin;PASSWORD=1562;";
        private static OracleConnection conn = new OracleConnection(connstr);
        private static OracleCommand cmd = new OracleCommand();

        public static void DML_NON_QUERY(string sql) //insert, delete, update
        {
            cmd.Connection = conn;
            cmd.CommandText = sql;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); //반환값 x ==>void
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }
        public static OracleDataReader DML_QUERY(string sql)
        {
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = null;


            try
            {
                conn.Open();
                dr=cmd.ExecuteReader();
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dr;
        }
    }
    
}

