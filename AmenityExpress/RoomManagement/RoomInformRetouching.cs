using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AmenityExpress.RoomManagement
{
    public partial class RoomInformRetouching : Form
    {
        public Room RoomData { get; private set; }
        public RoomInformRetouching(Room room)
        {
            InitializeComponent();
            RoomNameTextBox.Text = room.Name;
            RoomNumTextBox.Text = room.Num.ToString();
            RoomMaxTextBox.Text = room.MaxP.ToString();
            RoomPricetextBox.Text = room.Price.ToString();
            RoomNoticeTextBox.Text = room.Notice;
        }

        private void RoomPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void RoomNoticeLable_Click(object sender, EventArgs e)
        {

        }

        private void RoomNoticeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomMaxLable_Click(object sender, EventArgs e)
        {

        }

        private void RoomMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomPriceLable_Click(object sender, EventArgs e)
        {

        }

        private void RoomPricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNumLable_Click(object sender, EventArgs e)
        {

        }

        private void RoomNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNameLable_Click(object sender, EventArgs e)
        {

        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RetouchBtn_Click(object sender, EventArgs e)
        {
            int roomNum, maxP, price;
            if (int.TryParse(RoomNumTextBox.Text, out roomNum) &&
                int.TryParse(RoomMaxTextBox.Text, out maxP) &&
                int.TryParse(RoomPricetextBox.Text, out price))
            {
                RoomData = new Room(roomNum, RoomNameTextBox.Text, maxP, price, RoomNoticeTextBox.Text);
                UpdateRoomInDatabase(RoomData);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("유효한 값을 입력하세요.");
            }
        }
        private void UpdateRoomInDatabase(Room room)
        {
            string sql = "UPDATE ROOM_MANAGE SET NAME = :NAME, PRICE = :PRICE, MAX_CLIENT = :MAX_CLIENT, NOTICE = :NOTICE WHERE ROOMNUM = :ROOMNUM";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ROOMNAME", room.Name),
                new OracleParameter("ROOMPRICE", room.Price),
                new OracleParameter("ROOMMAXP", room.MaxP),
                new OracleParameter("ROOMNOTICE", room.Notice),
                new OracleParameter("ROOMNUM", room.Num)
            };

            try
            {
                DBConnector dbConnector = new DBConnector();
                dbConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("객실 정보가 업데이트되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("객실 정보 업데이트 중 오류가 발생했습니다: " + ex.Message);
            }
        }
            private void RoomInformRetouching_Load(object sender, EventArgs e)
        {

        }
    }
}
