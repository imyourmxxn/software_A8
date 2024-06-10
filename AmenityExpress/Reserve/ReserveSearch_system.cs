using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    internal class ReserveSearch_system
    {
        public static void reservelist(ListView Reservelist_listView, Client client, bool check)
        {
            if (check)
            {
                string sql = "SELECT * FROM RESERV_MANAGE";
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                string[] rows = new string[6];
                int i = 1;
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    rows[0] = row[2].ToString();
                    rows[1] = row[5].ToString();
                    rows[2] = row[0].ToString();
                    rows[3] = row[7].ToString();
                    rows[4] = row[1].ToString();
                    rows[5] = i.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
            else
            {
                string sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "'";
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                string[] rows = new string[6];
                int i = 1;
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    rows[0] = row[2].ToString();
                    rows[1] = row[5].ToString();
                    rows[2] = DateTime.Parse(row[0].ToString()).ToString("yyyy-MM-dd") + " 오후 15:00";
                    rows[3] = DateTime.Parse(row[7].ToString()).ToString("yyyy-MM-dd") + " 오전 10:00";
                    rows[4] = row[1].ToString();
                    rows[5] = i.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
        }

        public static void search_sys(string sql, ListView Reservelist_listView, TextBox Search_txt)
        {
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
            string[] rows = new string[6];
            int i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows) { i++; }
            if (i == 1) { MessageBox.Show("검색 결과 없음"); Search_txt.Text = ""; return; }
            i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                rows[0] = row[2].ToString();
                rows[1] = row[5].ToString();
                rows[2] = row[0].ToString();
                rows[3] = row[7].ToString();
                rows[4] = row[1].ToString();
                rows[5] = i.ToString();
                i++;
                var listViewItem = new ListViewItem(rows);
                Reservelist_listView.Items.Add(listViewItem);
            }
        }
    }
}
