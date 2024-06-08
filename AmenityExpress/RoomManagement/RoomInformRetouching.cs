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
        private string selectedImagePath;
        public RoomInformRetouching(Room room)
        {
            InitializeComponent();
            RoomNameTextBox.Text = room.Name;
            RoomNumTextBox.Text = room.Num.ToString();
            RoomMaxTextBox.Text = room.MaxP.ToString();
            RoomPricetextBox.Text = room.Price.ToString();
            RoomNoticeTextBox.Text = room.Notice;
            selectedImagePath = room.ImagePath;
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
                RoomData = new Room(roomNum, RoomNameTextBox.Text, maxP, price, RoomNoticeTextBox.Text, selectedImagePath);
                RoomData.Update_Room(RoomData);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("유효한 값을 입력하세요.");
            }
        }
        
            private void RoomInformRetouching_Load(object sender, EventArgs e)
        {
            
        }

        private void ImageReuploadBtn_Click(object sender, EventArgs e)
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
