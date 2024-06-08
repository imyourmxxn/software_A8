using AmenityExpress;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class Pay_Form : Form
    {
        Client client;

        public Room RoomData { get; private set; }
        public Pay_Form(Client client, Reserve reserve)
        {
            InitializeComponent();
            this.client = client;

            label9.Text = reserve.CKIN + "~" + reserve.CKOUT;
            label10.Text = reserve.RoomNum.ToString();
            textBox1.Text = client.Point.ToString();
            DBPrice(reserve.RoomNum);
            label3.Text = RoomData.Price.ToString();
            label4.Text = RoomData.Price.ToString();
            label6.Text = client.Point.ToString();
            int Total = Point_Payment(client.Point,RoomData.Price);
            label8.Text = Total.ToString();


        }
            
            public int Point_Payment(int point, int price)
        {
             
            point = client.Point;
            price = RoomData.Price;
            int total = price - point;
            return total;

        }
        public void DBPrice(int roomNum)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT PRICE FROM ROOM_MANAGE WHERE ROOMNUM = :ROOMNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ROOMNUM", roomNum)
            };
            ds = DBConnector.DML_QUERY(sql, parameters);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int price = Convert.ToInt32(ds.Tables[0].Rows[0]["PRICE"]);
                RoomData.Price = price;


            }
            else
            {
                MessageBox.Show("해당 방 번호에 대한 가격 정보를 찾을 수 없습니다.");
            }
        }
        
    
        private void Pay_Form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제 및 예약이 완료되었습니다.");
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
