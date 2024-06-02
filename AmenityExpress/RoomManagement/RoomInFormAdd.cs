using AmenityExpress;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class RoomInFormAdd : Form
    {
        private ListView parentListView;
        public Room RoomData { get; private set; }
        private string selectedImagePath;
        public RoomInFormAdd(ListView listView)
        {
            InitializeComponent();
            this.parentListView = listView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DialogForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int roomNum, maxP, price;
            if (int.TryParse(RoomNumTextBox.Text, out roomNum) &&
                int.TryParse(RoomMaxTextBox.Text, out maxP) &&
                int.TryParse(RoomPricetextBox.Text, out price))
            {
                RoomData = new Room(roomNum, RoomNameTextBox.Text, maxP, price, RoomNoticeTextBox.Text, selectedImagePath);
                InsertRoom(RoomData);  // DB에 값을 넣는 함수 실행

                // 부모 폼의 ListView를 업데이트
                DBRoomConnect.LoadRoomData(parentListView);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("유효한 값을 입력하세요.");
            }
        }

        private void RoomPriceLable_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InsertRoom(Room room) // 객체 정보를 받아와서 DB에 삽입하는 함수
        {
            string sql = "INSERT INTO ROOM_MANAGE (ROOMNUM, NAME, MAX_CLIENT, PRICE, NOTICE, PHOTOPATH) VALUES (:ROOMNUM, :NAME, :MAX_CLIENT, :PRICE, :NOTICE, :PHOTOPATH)";
            // INSERT INTO 테이블명 (ROOMNUM, NAME, MAX_CLIENT, PRICE, NOTICE)는 컬럼 이름과 일치해야 함
            // :ROOMNUM, :NAME 등은 매개변수 이름
            OracleParameter[] parameters = new OracleParameter[]{
                new OracleParameter("ROOMNUM", room.Num), // 매개변수 이름에 객체 인스턴스 값을 넣는다.
                new OracleParameter("NAME", room.Name),
                new OracleParameter("MAX_CLIENT", room.MaxP),
                new OracleParameter("PRICE", room.Price),
                new OracleParameter("NOTICE", room.Notice),
                new OracleParameter("PHOTOPATH", room.ImagePath) // PHOTOPATH로 수정
            };
            DBConnector dbConnector = new DBConnector(); // DB 연결을 위한 객체 생성
            dbConnector.DML_NON_QUERY(sql, parameters); // DB 객체 내에 있는 메소드 사용해서 삽입 실행
        }

        private void ImageAddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                RoomPictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
