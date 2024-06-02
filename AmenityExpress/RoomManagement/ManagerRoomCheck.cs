using AmenityExpress;
using AmenityExpress.RoomManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomSearchM_Form_Load(object sender, EventArgs e)
        {
            LoadRoomData();
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
                    item.Tag = room.ImagePath;
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
                    selectedItem.SubItems[4].Text,
                    selectedItem.Tag?.ToString()
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
                        selectedItem.Tag = updatedRoom.ImagePath;

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
        private void LoadRoomData()
        {
            string sql = "SELECT NAME, ROOMNUM, PRICE, MAX_CLIENT, NOTICE, PHOTOPATH FROM ROOM_MANAGE";
            DataSet ds = DBConnector.DML_QUERY(sql);

            listView1.Items.Clear();

            // 이미지 리스트 생성
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50); // 이미지 크기 조정 (가로, 세로)

            // 이미지를 표시할 이미지 리스트에 이미지 추가
            Dictionary<int, int> imageIndexMapping = new Dictionary<int, int>();
            int imageIndex = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string imagePath = ds.Tables[0].Rows[i]["PHOTOPATH"].ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        // 이미지 리스트에 이미지 추가
                        imageList.Images.Add(Image.FromFile(imagePath));
                        imageIndexMapping[i] = imageIndex;
                        imageIndex++;
                    }
                    catch (Exception ex)
                    {
                        // 이미지 로드 실패 시 처리할 내용
                        Console.WriteLine($"이미지 로드 실패: {ex.Message}");
                        imageIndexMapping[i] = -1; // 이미지 로드 실패 시 인덱스를 -1로 설정
                    }
                }
                else
                {
                    imageIndexMapping[i] = -1; // 이미지가 없는 경우 인덱스를 -1로 설정
                }
            }

            // 리스트뷰에 이미지 리스트 연결
            listView1.SmallImageList = imageList;

            // 각 항목에 이미지 인덱스 설정하여 이미지 표시
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(new[]
                {
            ds.Tables[0].Rows[i]["NAME"].ToString(),
            ds.Tables[0].Rows[i]["ROOMNUM"].ToString(),
            ds.Tables[0].Rows[i]["PRICE"].ToString(),
            ds.Tables[0].Rows[i]["MAX_CLIENT"].ToString(),
            ds.Tables[0].Rows[i]["NOTICE"].ToString()
        });

                if (imageIndexMapping[i] != -1)
                {
                    item.ImageIndex = imageIndexMapping[i]; // 이미지 인덱스 설정
                }

                listView1.Items.Add(item);
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

        private void RoomRenewal_btn_Click(object sender, EventArgs e)
        {
            LoadRoomData();
        }
    }
}
