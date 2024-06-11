using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    class RequestAnswerControl
    {
        public bool CheckAnswer(TextBox answer)  //요청사항에 대한 답변을 작성 완료했는 지 체크하는 메소드
        {
            if (string.IsNullOrWhiteSpace(answer.Text))  //요청사항에 대한 답변을 적지 않고 답변등록 버튼 클릭시,
            {
                MessageBox.Show("답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); //오류메세지 박스 출력
                return false;
            }
            else //답변을 작성하고 답변 등록 버튼 클릭했을 경우,
            {
                return true; //요청사항에 대한 답변이 작성됨을 확인
            }
        }

        public void ManageAnswer(RequestAnswer_Form UI, Request request,Manager manager)
        {
            if (this.CheckAnswer(UI.RequestAnswer_txt))
            {
                request.Answer = UI.RequestAnswer_txt.Text;
                request.Mid = manager.Id;
                request.AnswerDate = DateTime.Now;
                request.RequestAnswerEnroll(); // Request의 entity 클래스에서 받아옴
                if (DialogResult.OK == MessageBox.Show("답변이 완료되었습니다.", "답변 완료", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    UI.Close();
                }
            }
        }
    }

    class RequestWriteControl
    {
        public bool CheckRequest(TextBox content, ComboBox kindcombo)//요청사항 작성 완료했는 지 체크하는 메소드
        {
            if (string.IsNullOrWhiteSpace(kindcombo.SelectedItem == null ? "" : kindcombo.SelectedItem.ToString())) //요청사항 종류를 선택하지 않고 등록버튼 클릭시
            {
                MessageBox.Show("요청사항 종류를 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(content.Text)) //요청사항 내용을 입력하지 않고 등록버튼 클릭시
            {
                MessageBox.Show("요청사항을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;//요청사항이 작성됨을 확인
            }
        }
        public void CustomEnroll(RequestWrite_Form UI,Request request) 
        {
            if(this.CheckRequest(UI.RequestContent_txt, UI.RequestKind_CmBox)) //요청사항 종류와 요청사항이 제대로 입력됐는지 bool값으로 판단하는 함수
            {
                request.RequestWriteEnroll(); //엔티티 클래스의 RequestWriteEnroll 함수 불러와서 DB에 삽입  
                DialogResult ok = MessageBox.Show("요청사항이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ok == DialogResult.OK) //메세지박 스의 ok버튼 클릭시 요청사항 목록 폼으로 넘어감
                {
                    // 새로운 폼을 생성하고 표시
                    RequestList_Form requestlist_form = new RequestList_Form();
                    requestlist_form.Show();
                }
            }
        }
       
    }

    internal class RoomInformation_Del
    {
        public static void Del_Room(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                int roomNum = int.Parse(selectedItem.SubItems[1].Text);

                Room.Delete_Room(roomNum);

                listView.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }
    }
    internal class RoomInformationadd
    {
        public static void Add_Room(TextBox RoomNumTextBox, TextBox RoomMaxTextBox, TextBox RoomPricetextBox, TextBox RoomNameTextBox, TextBox RoomNoticeTextBox, string selectedImagePath, ListView parentListView)
        {
            int roomNum, maxP, price;
            if (int.TryParse(RoomNumTextBox.Text, out roomNum) &&
                int.TryParse(RoomMaxTextBox.Text, out maxP) &&
                int.TryParse(RoomPricetextBox.Text, out price))
            {
                Room RoomData = new Room(roomNum, RoomNameTextBox.Text, maxP, price, RoomNoticeTextBox.Text, selectedImagePath);
                RoomData.Room_Insert(RoomData);  // DB에 값을 넣는 함수 실행 

                // 부모 폼의 ListView를 업데이트
                Room.LoadRoomData(parentListView);
            }
            else
            {
                MessageBox.Show("유효한 값을 입력하세요.");
            }
        }
    }

    internal class RoomInformationRetouch
    {
        public static void RetouchRoom(int roomNum, string name, int maxP, int price, string notice, string imagePath)
        {
            Room roomData = new Room(roomNum, name, maxP, price, notice, imagePath);
            roomData.Update_Room(roomData);
        }
    }

    internal class ReserveSearch_system
    {
        public static void reservelist(ListView Reservelist_listView, Client client, bool check)
        {
            if (check)
            {
                string sql = "SELECT * FROM RESERV_MANAGE";
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                string[] rows = new string[6];
                int i = 1;
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    rows[0] = row[2].ToString();
                    rows[1] = row[5].ToString();
                    rows[2] = row[0].ToString();
                    rows[3] = row[7].ToString();
                    rows[4] = row[1].ToString();
                    rows[5] = i.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
            else
            {
                string sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "'";
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                string[] rows = new string[6];
                int i = 1;
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    rows[0] = row[2].ToString();
                    rows[1] = row[5].ToString();
                    rows[2] = DateTime.Parse(row[0].ToString()).ToString("yyyy-MM-dd") + " 오후 15:00";
                    rows[3] = DateTime.Parse(row[7].ToString()).ToString("yyyy-MM-dd") + " 오전 10:00";
                    rows[4] = row[1].ToString();
                    rows[5] = i.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
        }

        public static void search_sys(string sql, ListView Reservelist_listView, TextBox Search_txt)
        {
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
            string[] rows = new string[6];
            int i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows) { i++; }
            if (i == 1) { MessageBox.Show("검색 결과 없음"); Search_txt.Text = ""; return; }
            i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                rows[0] = row[2].ToString();
                rows[1] = row[5].ToString();
                rows[2] = row[0].ToString();
                rows[3] = row[7].ToString();
                rows[4] = row[1].ToString();
                rows[5] = i.ToString();
                i++;
                var listViewItem = new ListViewItem(rows);
                Reservelist_listView.Items.Add(listViewItem);
            }
        }
    }
}
