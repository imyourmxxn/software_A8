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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AmenityExpress
{
    public partial class Reservlist_Form : Form
    {
        Client client;
        bool check;
        public Reservlist_Form(Client client, bool check)
        {
            InitializeComponent();
            this.client = client;
            this.check = check;
            reservelist_view(check);
            Room_cbb.SelectedIndex = 0;
        }


        public void reservelist_view(bool check) 
        {
            ReserveSearch_system.reservelist(Reservelist_listView, client, check);
        }

        private void Reservlist_Form_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            search_sys(check);
        }

        public void search_sys(bool check)
        {
            Reservelist_listView.Items.Clear();
            string sql;
            if (check)
            {
                if (DateTime.Compare(CKOUT_dtp.Value.Date, CKIN_dtp.Value.Date) < 0)
                {
                    MessageBox.Show("체크아웃 날짜가 체크인 날짜보다 빠를 수 없습니다.");
                    return;
                }
                else if (String.IsNullOrWhiteSpace(Search_txt.Text) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() == Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "'";

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "' AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";

                }
            }
            else
            {
                if (DateTime.Compare(CKOUT_dtp.Value.Date, CKIN_dtp.Value.Date) < 0)
                {
                    MessageBox.Show("체크아웃 날짜가 체크인 날짜보다 빠를 수 없습니다.");
                    return;
                }
                else if (String.IsNullOrWhiteSpace(Search_txt.Text) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() == Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "'";

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "' AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";

                }
            }
            ReserveSearch_system.search_sys(sql, Reservelist_listView, Search_txt);
        }

        private void Room_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reservelist_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (Reservelist_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Reservelist_listView.SelectedItems[0];
                string sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN BETWEEN TO_DATE('" + DateTime.Parse(selectedItem.SubItems[2].Text.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND TO_DATE('" + DateTime.Parse(selectedItem.SubItems[2].Text.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') + 0.99999 AND ROOMNUM = " + Convert.ToInt32(selectedItem.SubItems[4].Text);
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                Reserve reserve = new Reserve("", "", "", "", "", DateTime.Now, DateTime.Now, 1111, "");
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    string CKIN = row[0].ToString();
                    DateTime myDate = DateTime.Parse(CKIN);
                    reserve.Name_KR = row[2].ToString();
                    reserve.Name_ENG = row[3].ToString();
                    reserve.ID = row[4].ToString();
                    reserve.Email = row[6].ToString();
                    reserve.Tell = row[5].ToString();
                    reserve.CKIN = DateTime.Parse(row[0].ToString());
                    reserve.CKOUT = DateTime.Parse(row[7].ToString());
                    reserve.RoomNum = Convert.ToInt32(row[1].ToString());
                    reserve.PRE_REQUEST = row[8].ToString();
                }

                if (check)
                {
                    Reservcheck_Form form = new Reservcheck_Form(null, reserve);
                    this.Visible = false;
                    form.Owner = this;
                    form.ShowDialog();
                }
                else
                {
                    Reservcheck_Form form = new Reservcheck_Form(client, reserve);
                    this.Visible = false;
                    form.Owner = this;
                    form.ShowDialog();
                }


                this.Visible = true;
                Reservelist_listView.Items.Clear();
                reservelist_view(check);
            }
            else
            {
                MessageBox.Show("항목을 선택하세요.");
            }
        }
    }
}
