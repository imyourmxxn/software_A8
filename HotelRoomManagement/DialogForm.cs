using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomManagement
{
    public partial class DialogForm : Form
    {
        public Room RoomData { get; private set; }
        public DialogForm()
        {
            InitializeComponent();
            
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
            if(int.TryParse(RoomNumTextBox.Text, out roomNum) &&
                int.TryParse(RoomMaxTextBox.Text, out maxP) &&
                int.TryParse(RoomPricetextBox.Text,out price))
            {
                RoomData = new Room(roomNum, RoomNameTextBox.Text, maxP, price, RoomNoticeTextBox.Text);
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
    }
}
