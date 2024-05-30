using AmenityExpress;
using AmenityExpress.RoomManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class ManagerRoomCheck : Form
    {
        public ManagerRoomCheck()
        {
            InitializeComponent();

            listView1.Columns.Add("Room Name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Price", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room MaxP", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Notice", 150, HorizontalAlignment.Left);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomSearchM_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (RoomInFormAdd dialog = new RoomInFormAdd())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Room room = dialog.RoomData;

                    ListViewItem item = new ListViewItem(new[]
                    {
                        room.Name,
                        room.Num.ToString(),
                        room.Price.ToString(),
                        room.MaxP.ToString(),
                        room.Notice
                    });

                    listView1.Items.Add(item);
                }
            }
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
                    selectedItem.SubItems[4].Text
                );

                using (RoomInformRetouching dialog = new RoomInformRetouching(room))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Room updatedRoom = dialog.RoomData;

                        selectedItem.SubItems[0].Text = updatedRoom.Name;
                        selectedItem.SubItems[1].Text = updatedRoom.Num.ToString();
                        selectedItem.SubItems[2].Text = updatedRoom.Price.ToString();
                        selectedItem.SubItems[3].Text = updatedRoom.MaxP.ToString();
                        selectedItem.SubItems[4].Text = updatedRoom.Notice;
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
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int roomNum = int.Parse(selectedItem.SubItems[1].Text);

                DeleteRoom(roomNum);

                listView1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        private void DeleteRoom(int roomNum)
        {
            string sql = $"DELETE FROM ROOM_MANAGE WHERE ROOMNUM = {roomNum}";

            try
            {
                DBConnector.DML_NON_QUERY(sql);
                MessageBox.Show("객실 정보가 삭제되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("객실 정보 삭제 중 오류가 발생했습니다: " + ex.Message);
            }
        }
    }
}
