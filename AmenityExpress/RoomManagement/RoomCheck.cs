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
    public partial class RoomCheck : Form
    {
        Client client;
        Reserve reserve;
        public RoomCheck(Client client,Reserve reserve)
        {
            InitializeComponent();
            Room_list.Columns.Add("Room Name", 200, HorizontalAlignment.Left);
            Room_list.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            Room_list.Columns.Add("Room Price", 100, HorizontalAlignment.Left);
            Room_list.Columns.Add("Room Max_Client", 100, HorizontalAlignment.Left);
            Room_list.Columns.Add("Room Notice", 150, HorizontalAlignment.Left);

            Room_list.View = View.Details;
            Room_list.FullRowSelect = true;
            this.client = client;
            this.reserve = reserve;
        }

        private void Room_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reserve_btn_Click(object sender, EventArgs e)
        {
            if (Room_list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Room_list.SelectedItems[0];
                int roomNum = int.Parse(selectedItem.SubItems[1].Text);

                // 예약 로직을 여기에 추가합니다.
                this.Visible = false;
                Reserv_Form reserv_form = new Reserv_Form(reserve, client);
                reserv_form.Owner = this;
                reserv_form.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("예약할 방을 선택하세요.");
            }

        }

        private void RoomCheck_Load(object sender, EventArgs e)
        {
            Room.LoadRoomData(Room_list);
        }
    }
}
