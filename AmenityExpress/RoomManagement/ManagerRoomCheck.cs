using AmenityExpress.RoomManagement;
using System;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class ManagerRoomCheck : Form
    {
        public ManagerRoomCheck()
        {
            InitializeComponent();

            listView1.Columns.Add("Room Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Price", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Max_Client", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Notice", 150, HorizontalAlignment.Left);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void RoomSearchM_Form_Load(object sender, EventArgs e)
        {
            Room.LoadRoomData(listView1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (RoomInFormAdd dialog = new RoomInFormAdd(listView1))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Room.LoadRoomData(listView1); // 폼이 닫힌 후에도 데이터를 다시 로드
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Room room = new Room(
                    int.Parse(selectedItem.SubItems[1].Text),
                    selectedItem.SubItems[0].Text,
                    int.Parse(selectedItem.SubItems[3].Text),
                    int.Parse(selectedItem.SubItems[2].Text),
                    selectedItem.SubItems[4].Text,
                    selectedItem.Tag?.ToString()
                );

                using (RoomInformRetouching dialog = new RoomInformRetouching(room))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Room.LoadRoomData(listView1);
                    }
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            RoomInformation_Del.Del_Room(listView1);
        }

        private void RoomRenewal_btn_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
