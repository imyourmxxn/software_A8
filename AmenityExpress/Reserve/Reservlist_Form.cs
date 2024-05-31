using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AmenityExpress
{
    public partial class Reservlist_Form : Form
    {
        Client client;
        public Reservlist_Form(Client client)
        {
            InitializeComponent();
            this.client = client;
            reservelist_view();
            Room_cbb.SelectedIndex = 0;
        }

        public void reservelist_view() 
        {
            string sql = "SELECT * FROM RESERV_MANAGE";
            DataSet dbconnector = DBConnector.DML_QUERY(sql);
            string[] rows = new string[4];
            int i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                rows[0] = row[2].ToString();
                rows[1] = row[5].ToString();
                rows[2] = row[1].ToString();
                rows[3] = i.ToString();
                i++;
                var listViewItem = new ListViewItem(rows);
                Reservelist_listView.Items.Add(listViewItem);
            }
        }

        private void Reservlist_Form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_sys();
        }

        public void search_sys()
        {
            Reservelist_listView.Items.Clear();
            if (DateTime.Compare(CKOUT_dtp.Value.Date, CKIN_dtp.Value.Date) < 0)
            {
                MessageBox.Show("체크아웃 날짜가 체크인 날짜보다 빠를 수 없습니다.");
                return;
            }
            else if (String.IsNullOrWhiteSpace(Search_txt.Text) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
            {
                string sql = @"
                SELECT *
                FROM RESERV_MANAGE
                WHERE CKIN >= @CKIN_dtp AND CKOUT <= @CKOUT_dtp AND ROOMNUM == @Room_cbb";

                OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("CKIN_dtp", CKIN_dtp.Value.Date),
                new OracleParameter("CKOUT_dtp", CKOUT_dtp.Value.Date),
                new OracleParameter("Room_cbb", Convert.ToInt32(Room_cbb.ToString()))
                };
            }
            else
            {
                string sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";
                DataSet dbconnector = DBConnector.DML_QUERY(sql);
                string[] rows = new string[4];
                int i = 1;
                if (dbconnector == null) { MessageBox.Show("검색 결과 없음"); return; }
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    rows[0] = row[2].ToString();
                    rows[1] = row[5].ToString();
                    rows[2] = row[1].ToString();
                    rows[3] = i.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
        }

        private void Room_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
