using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        public RequestAnswerControl() {} //요청사항에 대한 답변 등록
        public void RequestAnswerEnroll(RequestAnswer_Form UI,Manager manager,Request request, EventHandler e)
        {
            string sql = "UPDATE REQUEST_MANAGE SET STATUE=:STATUE, MID=:MID, ANSWERDATE=:ANSWERDATE, ANSWER=:ANSWER WHERE SNUM = :SNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
               new OracleParameter("STATUE","답변 완료"),
               new OracleParameter("MID",manager.Id),
                new OracleParameter("ANSWERDATE", request.AnswerDate),
                new OracleParameter("ANSWER", request.Answer),
                new OracleParameter("SNUM",request.SNum)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("답변이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Invoke(UI,EventArgs.Empty);
                UI.Close();
            }
            catch
            {
                MessageBox.Show("요청사항에 대한 답변이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
    }

    class RequestWriteControl
    {
        public RequestWriteControl() { } //요청사항 등록
        public void RequestWriteEnroll(RequestWrite_Form UI, Reserve reserve, Request request) //요청사항 등록 메소드(DB에 데아터 삽입됨) + 여기 시퀀스 들어가는 부분
        {
                string sql = "INSERT INTO Request_Manage (STATUE, CID, ROOMNUM, WRITEDATE, REQUESTKIND, CONTENT) VALUES (:STATUE, :CID, :ROOMNUM, :WRITEDATE, :REQUESTKIND, :CONTENT)";
                OracleParameter[] parameters = new OracleParameter[]
                {
                new OracleParameter("STATUE",request.Statue),
                new OracleParameter("CID", reserve.ID),
                new OracleParameter("ROOMNUM",reserve.RoomNum),
                new OracleParameter("WRITEDATE", request.WriteDate),
                new OracleParameter("REQUESTKIND", request.RequestKind),
                new OracleParameter("CONTENT", request.Content)
                };
                try
                {
                    DBConnector.DML_NON_QUERY(sql, parameters);
                }
                catch
                {
                    MessageBox.Show("요청사항이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult enrollok = MessageBox.Show("요청사항이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (enrollok == DialogResult.OK) //메세지박스의 ok버튼 클릭시 요청사항 목록 폼으로 넘어감
                {
                    // 새로운 폼을 생성하고 표시
                    RequestList_Form requestlist_form = new RequestList_Form();
                    requestlist_form.Show();

                // 기존 폼을 숨김
                UI.Hide();
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
