using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace AmenityExpress
{
    class memberControl
    {
        public static void Client_Add(Client client)
        {
            try
            {
                client.AddInform(); // Client 클래스의 AddInform() 메서드 호출
            }
            catch (Exception ex)
            {
                throw new Exception("클라이언트 정보를 추가하는 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        public static void Client_Fix(Client client)
        {
            try
            {
                client.FixInform(); // Client 클래스의 FixInform() 메서드 호출
            }
            catch (Exception ex)
            {
                throw new Exception("클라이언트 정보를 수정하는 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        public static void Client_Del(string id)
        {
            try
            {
                Client client = new Client(id, "", "", "", "", "", "", 0);
                client.ID = id; // 삭제할 클라이언트의 ID 설정
                client.DelInform(); // Client 클래스의 DelInform() 메서드 호출
            }
            catch (Exception ex)
            {
                throw new Exception("클라이언트 정보를 삭제하는 중 오류가 발생했습니다: " + ex.Message);
            }
        }
    }
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
                    UI.Hide();
                    // 새로운 폼을 생성하고 표시
                    RequestList_Form requestlist_form = new RequestList_Form();
                    requestlist_form.ShowDialog();
                    
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
        public Reserve reserve = null;

        public ReserveSearch_system() { }
        public void reservelist(ListView Reservelist_listView, Client client, bool check)
        {
            if (check)
            {
                string sql = "SELECT * FROM RESERV_MANAGE";
                DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
                string[] rows = new string[6];
                int i = 1;
                foreach (DataRow row in dbconnector.Tables[0].Rows)
                {
                    if (reserve == null)
                    {
                        reserve = new Reserve(row[2].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString(), row[4].ToString(), DateTime.Parse(row[0].ToString()), DateTime.Parse(row[7].ToString()), Convert.ToInt32(row[1].ToString()), row[8].ToString());
                    }
                    else
                    {
                        reserve.Name_KR = row[2].ToString();
                        reserve.Tell = row[5].ToString();
                        reserve.CKIN = DateTime.Parse(row[0].ToString());
                        reserve.CKOUT = DateTime.Parse(row[7].ToString());
                        reserve.RoomNum = Convert.ToInt32(row[1].ToString());
                        reserve.Name_ENG = row[3].ToString();
                        reserve.ID = row[4].ToString();
                        reserve.Email = row[6].ToString();
                        reserve.PRE_REQUEST = row[8].ToString();
                    }
                    
                    rows[0] = i.ToString();
                    rows[1] = reserve.Name_KR;
                    rows[2] = reserve.Tell;
                    rows[3] = reserve.CKIN.ToString("yyyy-MM-dd");
                    rows[4] = reserve.CKOUT.ToString("yyyy-MM-dd");
                    rows[5] = reserve.RoomNum.ToString();
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
                    if (reserve == null)
                    {
                        reserve = new Reserve(row[2].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString(), row[4].ToString(), DateTime.Parse(row[0].ToString()), DateTime.Parse(row[7].ToString()), Convert.ToInt32(row[1].ToString()), row[8].ToString());
                    }
                    else
                    {
                        reserve.Name_KR = row[2].ToString();
                        reserve.Tell = row[5].ToString();
                        reserve.CKIN = DateTime.Parse(row[0].ToString());
                        reserve.CKOUT = DateTime.Parse(row[7].ToString());
                        reserve.RoomNum = Convert.ToInt32(row[1].ToString());
                        reserve.Name_ENG = row[3].ToString();
                        reserve.ID = row[4].ToString();
                        reserve.Email = row[6].ToString();
                        reserve.PRE_REQUEST = row[8].ToString();
                    }

                    rows[0] = i.ToString();
                    rows[1] = reserve.Name_KR;
                    rows[2] = reserve.Tell;
                    rows[3] = reserve.CKIN.ToString("yyyy-MM-dd");
                    rows[4] = reserve.CKOUT.ToString("yyyy-MM-dd");
                    rows[5] = reserve.RoomNum.ToString();
                    i++;
                    var listViewItem = new ListViewItem(rows);
                    Reservelist_listView.Items.Add(listViewItem);
                }
            }
        }

        public void search_sys(DateTimePicker CKOUT_dtp, DateTimePicker CKIN_dtp, ComboBox Room_cbb, ListView Reservelist_listView, TextBox Search_txt, Client client, bool check)
        {
            Reservelist_listView.Items.Clear();
            string sql;
            if (check)
            {
                if (DateTime.Compare(CKOUT_dtp.Value.Date, CKIN_dtp.Value.Date) < 0)
                {
                    MessageBox.Show("체크아웃 날짜가 체크인 날짜보다 빠를 수 없습니다.");
                    return;
                }
                else if (String.IsNullOrWhiteSpace(Search_txt.Text) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() == Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "'";

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "' AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";

                }
            }
            else
            {
                if (DateTime.Compare(CKOUT_dtp.Value.Date, CKIN_dtp.Value.Date) < 0)
                {
                    MessageBox.Show("체크아웃 날짜가 체크인 날짜보다 빠를 수 없습니다.");
                    return;
                }
                else if (String.IsNullOrWhiteSpace(Search_txt.Text) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() == Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "'";

                }
                else if (!(String.IsNullOrWhiteSpace(Search_txt.Text)) && Room_cbb.SelectedItem.ToString() != Room_cbb.Items[0].ToString())
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND KRNAME = '" + Search_txt.Text.ToString() + "' AND ROOMNUM = " + Convert.ToInt32(Room_cbb.Text.ToString());

                }
                else
                {
                    sql = "SELECT * FROM RESERV_MANAGE WHERE ID = '" + client.ID + "' AND CKIN >= TO_DATE('" + CKIN_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND CKOUT <= TO_DATE('" + CKOUT_dtp.Value.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')";

                }
            }
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
            string[] rows = new string[6];
            int i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows) { i++; }
            if (i == 1) { MessageBox.Show("검색 결과 없음"); Search_txt.Text = ""; return; }
            i = 1;
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                if (reserve == null)
                {
                    reserve = new Reserve(row[2].ToString(), row[3].ToString(), row[5].ToString(), row[6].ToString(), row[4].ToString(), DateTime.Parse(row[0].ToString()), DateTime.Parse(row[7].ToString()), Convert.ToInt32(row[1].ToString()), row[8].ToString());
                }
                else
                {
                    reserve.Name_KR = row[2].ToString();
                    reserve.Tell = row[5].ToString();
                    reserve.CKIN = DateTime.Parse(row[0].ToString());
                    reserve.CKOUT = DateTime.Parse(row[7].ToString());
                    reserve.RoomNum = Convert.ToInt32(row[1].ToString());
                    reserve.Name_ENG = row[3].ToString();
                    reserve.ID = row[4].ToString();
                    reserve.Email = row[6].ToString();
                    reserve.PRE_REQUEST = row[8].ToString();
                }

                rows[0] = i.ToString();
                rows[1] = reserve.Name_KR;
                rows[2] = reserve.Tell;
                rows[3] = reserve.CKIN.ToString("yyyy-MM-dd");
                rows[4] = reserve.CKOUT.ToString("yyyy-MM-dd");
                rows[5] = reserve.RoomNum.ToString();
                i++;
                var listViewItem = new ListViewItem(rows);
                Reservelist_listView.Items.Add(listViewItem);
            }
        }

        public Reserve selected_Load(ListViewItem selectedItem)
        {
            string sql = @"SELECT * FROM RESERV_MANAGE WHERE CKIN BETWEEN TO_DATE('" + DateTime.Parse(selectedItem.SubItems[3].Text.ToString()).ToString("yyyy-MM-dd") +
                         "', 'YYYY-MM-DD') AND TO_DATE('" + DateTime.Parse(selectedItem.SubItems[3].Text.ToString()).ToString("yyyy-MM-dd") +
                         "', 'YYYY-MM-DD') + 0.99999 AND ROOMNUM = " + Convert.ToInt32(selectedItem.SubItems[5].Text);
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
            Reserve reserve = new Reserve("", "", "", "", "", DateTime.Now, DateTime.Now, 1111, "");
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                reserve.Name_KR = row[2].ToString();
                reserve.Name_ENG = row[3].ToString();
                reserve.ID = row[4].ToString();
                reserve.Email = row[6].ToString();
                reserve.Tell = row[5].ToString();
                reserve.CKIN = DateTime.Parse(row[0].ToString());
                reserve.CKOUT = DateTime.Parse(row[7].ToString());
                reserve.RoomNum = Convert.ToInt32(row[1].ToString());
                reserve.PRE_REQUEST = row[8].ToString();
            }

            return reserve;
        }

        public Room search_Room(Reserve reserve)
        {
            string sql = "SELECT * FROM ROOM_MANAGE WHERE ROOMNUM = " + reserve.RoomNum;
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);
            Room room = null;
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                room = new Room(Convert.ToInt32(row[0].ToString()), row[1].ToString(), Convert.ToInt32(row[2].ToString()),
                    Convert.ToInt32(row[3].ToString()), row[4].ToString(), row[5].ToString());
            }
            return room;
        }
    }

    class Reserveinform_system
    {
        public Reserveinform_system() { }

        public void Reserve_Retouch(ComboBox Tell_cbb, TextBox KRname_txt, TextBox ENGname_txt, TextBox Email_txt, TextBox Tell_txt, TextBox Request_txt, Reserve reserve)
        {
            if (string.IsNullOrWhiteSpace(KRname_txt.Text) || string.IsNullOrWhiteSpace(ENGname_txt.Text) || string.IsNullOrWhiteSpace(Email_txt.Text) || string.IsNullOrWhiteSpace(Tell_txt.Text))
            {
                MessageBox.Show("올바른 입력정보를 입력하세요");
            }
            else
            {
                reserve.Name_KR = KRname_txt.Text.ToString();
                reserve.Name_ENG = ENGname_txt.Text.ToString();
                reserve.Email = Email_txt.Text.ToString();
                reserve.Tell = Tell_cbb.Text.ToString() + Tell_txt.Text.ToString();
                reserve.PRE_REQUEST = Request_txt.Text.ToString();

                if (!reserve.IsValidEmail(reserve.Email)) { MessageBox.Show("E-mail 형식이 다릅니다."); return; }
                if (reserve.TellNumCkeck(reserve.Tell.ToString()) == 1) { MessageBox.Show("전화번호 형식이 다릅니다."); return; }
                else if (reserve.TellNumCkeck(reserve.Tell.ToString()) == 2) { MessageBox.Show("전화번호 자릿수가 맞지 않습니다."); return; }

                reserve.reserve_retouch();

                MessageBox.Show("수정 완료");
            }
        }

    }
}
