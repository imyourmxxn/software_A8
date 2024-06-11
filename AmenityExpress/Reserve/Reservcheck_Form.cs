using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class Reservcheck_Form : Form
    {
        Reserve reserve;
        Client client;
        Room room;
        Reserveinform_system control = new Reserveinform_system();
        public Reservcheck_Form(Client client, Reserve reserve, Room room)
        {
            InitializeComponent();
            this.reserve = reserve;
            this.client = client;
            this.room = room;
            Reserve_set(reserve);
            LoadRoomImage(room.ImagePath);
        }

        private void LoadRoomImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                RoomPictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                // 기본 이미지 설정
                RoomPictureBox.Image = null; // 기본 이미지를 설정하거나 null로 설정
            }
        }
        public void Reserve_set(Reserve reserve)
        { 
            string[] phoneNumberSplit =reserve.Tell.Split('-');
            if (phoneNumberSplit[0] == "010") { Tell_cbb.SelectedIndex = 0; }
            else { Tell_cbb.SelectedIndex=1; }

            KRname_txt.Text = reserve.Name_KR;
            ENGname_txt.Text = reserve.Name_ENG;
            Email_txt.Text = reserve.Email;
            Tell_txt.Text = "-"+phoneNumberSplit[1] + "-" + phoneNumberSplit[2];
            Request_txt.Text = reserve.PRE_REQUEST;

            CKIN_lbl.Text = reserve.CKIN.ToString("MM월 dd일 (ddd)");
            CKOUT_lbl.Text = reserve.CKOUT.ToString("MM월 dd일 (ddd)");
            label6.Text = "객실정보 " + reserve.RoomNum.ToString() + "호 ( " + room.Name.ToString() + " )";
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Reservcheck_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reequest_btn_Click(object sender, EventArgs e)
        {
            RequestWrite_Form requestWrite_Form = new RequestWrite_Form(reserve);
            requestWrite_Form.Owner = this;
            requestWrite_Form.ShowDialog();
        }

        private void Retouch_btn_Click(object sender, EventArgs e)
        {
            control.Reserve_Retouch(Tell_cbb, KRname_txt, ENGname_txt, Email_txt, Tell_txt, Request_txt, reserve);
            Close();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            reserve.reserve_del();
            MessageBox.Show("삭제 완료");
            Close();
        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
