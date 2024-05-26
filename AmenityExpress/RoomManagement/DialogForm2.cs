using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress.RoomManagement
{
    public partial class DialogForm2 : Form
    {
        public Room RoomData { get; private set; }
        public DialogForm2(Room room)
        {
            InitializeComponent();
            if (room != null)
            {
                RoomNameTextBox.Text = room.Name;
                RoomNumTextBox.Text = room.Num.ToString();
                RoomMaxTextBox.Text = room.MaxP.ToString();
                RoomPricetextBox.Text = room.Price.ToString();
                RoomNoticeTextBox.Text = room.Notice;
            }
        }

        private void retouchBtn_Click(object sender, EventArgs e)
        {
            int roomNum, maxP, price;
            if (int.TryParse(RoomNumTextBox.Text, out roomNum) &&
                int.TryParse(RoomMaxTextBox.Text, out maxP) &&
                int.TryParse(RoomPricetextBox.Text, out price))
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

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DialogForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
