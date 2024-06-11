using AmenityExpress;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public class Manager
    {
        public string Name;
        public string Id;
        public string Pwd;
        public string Email;
        public string Tel;
        public string Gender;
        public string Birthday;
        public Manager(string Id, string Name, string Pwd, string Email, string Tel, string Gender, string Birthday)
        {
            this.Name = Name; this.Id = Id; this.Pwd = Pwd; this.Email = Email; this.Tel = Tel; this.Gender = Gender; this.Birthday = Birthday;
        }
    }
    public class Client
    {
        public string Name;
        public string ID;
        public string PW;
        public string Email;
        public string Tell;
        public string Sex;
        public string Birth;
        public int Point;
        public Client(string ID, string Name, string PW, string Email, string Tell, string Sex, string Birth, int Point)
        {
            this.Name = Name; this.ID = ID; this.PW = PW; this.Email = Email; this.Tell = Tell; this.Sex = Sex; this.Birth = Birth; this.Point = Point;
        }
        public void AddInform()
        {
            string sql = "INSERT INTO ADMIN.MEMBER_CLIENT (ID, NAME, PW, EMAIL, TEL, GENDER, BIRTH, POINT) " +
                         "VALUES (:ID, :Name, :PW, :Email, :Tel, :Gender, :Birth, :Point)";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ID", ID),
                new OracleParameter("Name", Name),
                new OracleParameter("PW", PW),
                new OracleParameter("Email", Email),
                new OracleParameter("Tel", Tell),
                new OracleParameter("Gender", Sex),
                new OracleParameter("Birth", Birth),
                new OracleParameter("Point", Point)
            };

            DBConnector.DML_NON_QUERY(sql, parameters);
        }

        public void FixInform()
        {
            string sql = "UPDATE ADMIN.MEMBER_CLIENT SET NAME=:Name, PW=:PW, EMAIL=:Email, TEL=:Tel, " +
                         "GENDER=:Gender, BIRTH=:Birth, POINT=:Point WHERE ID=:ID";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("Name", Name),
                new OracleParameter("PW", PW),
                new OracleParameter("Email", Email),
                new OracleParameter("Tel", Tell),
                new OracleParameter("Gender", Sex),
                new OracleParameter("Birth", Birth),
                new OracleParameter("Point", Point) ,
                new OracleParameter("ID", ID)
            };

            DBConnector.DML_NON_QUERY(sql, parameters);
        }

        public void DelInform()
        {
            string sql = "DELETE FROM ADMIN.MEMBER_CLIENT WHERE ID=:ID";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ID", ID)
            };

            DBConnector.DML_NON_QUERY(sql, parameters);
        }
    }


    public class Reserve
    {
        public string Name_KR;
        public string Name_ENG;
        public string Tell;
        public string Email;
        public string ID;
        public DateTime CKIN;
        public DateTime CKOUT;
        public int RoomNum;
        public string PRE_REQUEST;

        public Reserve(string Name_KR, string Name_ENG, string Tell, string Email, string ID, DateTime CKIN, DateTime CKOUT, int RoomNum, string PRE_REQUEST)
        {
            this.Name_KR = Name_KR; this.Name_ENG = Name_ENG; this.Tell = Tell; this.Email = Email; this.ID = ID; this.CKIN = CKIN; this.CKOUT = CKOUT; this.RoomNum = RoomNum; this.PRE_REQUEST = PRE_REQUEST;
        }

        public void reserve_dbset()
        {
            string query = "INSERT INTO RESERV_MANAGE (ROOMNUM, KRNAME, ENGNAME, ID, TEL, EMAIL, CKIN, CKOUT, PRE_REQUEST) VALUES (:ROOMNUM, :KR, :ENG, :ID, :TEL, :EMAIL, :CKIN, :CKOUT, :PRE_REQUEST)";
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ROOMNUM", RoomNum),
                new OracleParameter("KR", Name_KR),
                new OracleParameter("ENG", Name_ENG),
                new OracleParameter("ID", ID),
                new OracleParameter("TEL", Tell),
                new OracleParameter("EMAIL", Email),
                new OracleParameter("CKIN", CKIN),
                new OracleParameter("CKOUT", CKOUT),
                new OracleParameter("PRE_REQUEST", PRE_REQUEST)
            };
            DBConnector.DML_NON_QUERY(query, parameters);
        }

        public void reserve_retouch()
        {
            string query = "UPDATE RESERV_MANAGE SET KRNAME = :KR, ENGNAME = :ENG,  TEL = :TEL, EMAIL = :EMAIL, PRE_REQUEST = :PRE_REQUEST WHERE ROOMNUM = :RoomNum AND CKIN BETWEEN TO_DATE('" + DateTime.Parse(CKIN.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND TO_DATE('" + DateTime.Parse(CKIN.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') + 0.99999";
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("KR", Name_KR),
                new OracleParameter("ENG", Name_ENG),
                new OracleParameter("TEL", Tell),
                new OracleParameter("EMAIL", Email),
                new OracleParameter("PRE_REQUEST", PRE_REQUEST),
                new OracleParameter("ROOMNUM", RoomNum)
            };
            DBConnector.DML_NON_QUERY(query, parameters);
        }

        public void reserve_del()
        {
            string query = "DELETE RESERV_MANAGE WHERE ROOMNUM = :RoomNum AND CKIN BETWEEN TO_DATE('" + DateTime.Parse(CKIN.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') AND TO_DATE('" + DateTime.Parse(CKIN.ToString()).ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') + 0.99999";
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ROOMNUM", RoomNum)
            };
            DBConnector.DML_NON_QUERY(query, parameters);
        }

        public int TellNumCkeck(string Tell)
        {
            if (Tell.Length == 12 || Tell.Length == 13)
            {
                Regex regex = new Regex(@"01{1}[01]{1}-[0-9]{3,4}-[0-9]{4}");

                Match m = regex.Match(Tell);
                if (m.Success) { return 0; }
                else { return 1; }
            }
            else { return 2; }
        }

        public bool IsValidEmail(string email)
        {
            bool valid = Regex.IsMatch(email, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
            return valid;
        }

    }


    public class Request
    {
        public int SNum;
        public string Statue;
        public string RequestKind;
        public string Content;
        public DateTime WriteDate;
        public string Answer;
        public DateTime? AnswerDate;
        public string Cid;
        public string Mid;
        public int Roomnum;

        public Request(int SNum, string Statue, string Cid, int Roomnum, DateTime WriteDate, string RequestKind, string Content, string Mid, DateTime? AnswerDate, string Answer)
        {
            this.SNum = SNum; this.Statue = Statue; this.RequestKind = RequestKind; this.Content = Content; this.Answer = Answer; this.Cid = Cid;
            this.Mid = Mid; this.Roomnum = Roomnum; this.WriteDate = WriteDate; this.AnswerDate = AnswerDate;
        }

        public void RequestWriteEnroll() //요청사항 등록 메소드(DB에 데이터 삽입됨) + 여기 시퀀스 들어가는 부분
        {
            string sql = "INSERT INTO Request_Manage (STATUE, CID, ROOMNUM, WRITEDATE, REQUESTKIND, CONTENT) VALUES (:STATUE, :CID, :ROOMNUM, :WRITEDATE, :REQUESTKIND, :CONTENT)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("STATUE",Statue),
                new OracleParameter("CID", Cid),
                new OracleParameter("ROOMNUM",Roomnum),
                new OracleParameter("WRITEDATE", WriteDate),
                new OracleParameter("REQUESTKIND", RequestKind),
                new OracleParameter("CONTENT", Content)
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
        }

        public void RequestAnswerEnroll()
        {
            string sql = "UPDATE REQUEST_MANAGE SET STATUE=:STATUE, MID=:MID, ANSWERDATE=:ANSWERDATE, ANSWER=:ANSWER WHERE SNUM = :SNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
               new OracleParameter("STATUE","답변 완료"),
               new OracleParameter("MID",Mid),
                new OracleParameter("ANSWERDATE", AnswerDate),
                new OracleParameter("ANSWER", Answer),
                new OracleParameter("SNUM", SNum)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                //MessageBox.Show("답변이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //e.Invoke(UI, EventArgs.Empty);
                //UI.Close();
            }
            catch
            {
                MessageBox.Show("요청사항에 대한 답변이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }


    public class Room
    {
        public int Num;
        public string Name;
        public int MaxP;
        public int Price;
        public string Notice;
        public string ImagePath;


        public Room(int Num, string Name, int MaxP, int Price, string Notice, string imagePath)
        {
            this.Num = Num; this.Name = Name; this.MaxP = MaxP; this.Price = Price; this.Notice = Notice; this.ImagePath = imagePath;
        }
        public void Room_Insert(Room room) // 객체 정보를 받아와서 DB에 삽입하는 함수
        {
            string sql = "INSERT INTO ROOM_MANAGE (ROOMNUM, NAME, MAX_CLIENT, PRICE, NOTICE, PHOTOPATH) VALUES (:ROOMNUM, :NAME, :MAX_CLIENT, :PRICE, :NOTICE, :PHOTOPATH)";
            // INSERT INTO 테이블명 (ROOMNUM, NAME, MAX_CLIENT, PRICE, NOTICE)는 컬럼 이름과 일치해야 함
            // :ROOMNUM, :NAME 등은 매개변수 이름
            OracleParameter[] parameters = new OracleParameter[]{
                new OracleParameter("ROOMNUM", room.Num), // 매개변수 이름에 객체 인스턴스 값을 넣는다.
                new OracleParameter("NAME", room.Name),
                new OracleParameter("MAX_CLIENT", room.MaxP),
                new OracleParameter("PRICE", room.Price),
                new OracleParameter("NOTICE", room.Notice),
                new OracleParameter("PHOTOPATH", room.ImagePath) // PHOTOPATH로 수정
            };
            DBConnector.DML_NON_QUERY(sql, parameters); // DB 객체 내에 있는 메소드 사용해서 삽입 실행
        }
        public void Update_Room(Room room)
        {
            string sql = "UPDATE ROOM_MANAGE SET NAME = :NAME, PRICE = :PRICE, MAX_CLIENT = :MAX_CLIENT, NOTICE = :NOTICE, PHOTOPATH = :PHOTOPATH WHERE ROOMNUM = :ROOMNUM";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("NAME", room.Name),
                new OracleParameter("PRICE", room.Price),
                new OracleParameter("MAX_CLIENT", room.MaxP),
                new OracleParameter("NOTICE", room.Notice),
                new OracleParameter("PHOTOPATH", room.ImagePath),
                new OracleParameter("ROOMNUM", room.Num)
            };

            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("객실 정보가 업데이트되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("객실 정보 업데이트 중 오류가 발생했습니다: " + ex.Message);
            }
        }
        public static void Delete_Room(int roomNum)
        {
            string sql = $"DELETE FROM ROOM_MANAGE WHERE ROOMNUM = :RoomNum";
            OracleParameter[] parameters = new OracleParameter[]
            {
            new OracleParameter(":RoomNum", roomNum)
            };

            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("객실 정보가 삭제되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("객실 정보 삭제 중 오류가 발생했습니다: " + ex.Message);
            }
        }
        public static void LoadRoomData(ListView listView)
        {

            string sql = "SELECT NAME, ROOMNUM, PRICE, MAX_CLIENT, NOTICE, PHOTOPATH FROM ROOM_MANAGE";


            DataSet ds = DBConnector.DML_QUERY(sql, null);


            listView.Items.Clear();


            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(50, 50);

            // 빈 이미지를 생성하고 ImageList에 추가합니다. 이 이미지는 0번 인덱스에 추가됩니다.
            Bitmap emptyImage = new Bitmap(50, 50);
            imageList.Images.Add(emptyImage);

            // 데이터셋의 각 행에 대해 반복합니다.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // 현재 행의 PHOTOPATH 값을 가져옵니다.
                string imagePath = ds.Tables[0].Rows[i]["PHOTOPATH"].ToString();

                // PHOTOPATH 값이 비어 있지 않은 경우
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        // 지정된 경로에서 이미지를 로드하여 ImageList에 추가합니다.
                        imageList.Images.Add(Image.FromFile(imagePath));
                    }
                    catch (Exception ex)
                    {
                        // 이미지 로드에 실패한 경우 예외 메시지를 출력하고, 빈 이미지를 추가합니다.
                        Console.WriteLine($"이미지 로드 실패: {ex.Message}");
                        imageList.Images.Add(emptyImage);
                    }
                }
                else
                {
                    // PHOTOPATH 값이 비어 있는 경우 빈 이미지를 추가합니다.
                    imageList.Images.Add(emptyImage);
                }
            }

            // ListView의 SmallImageList 속성에 ImageList를 연결합니다.
            listView.SmallImageList = imageList;

            // 데이터셋의 각 행에 대해 ListViewItem을 생성하고 ListView에 추가합니다.
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // 현재 행의 데이터를 사용하여 ListViewItem을 생성합니다.
                ListViewItem item = new ListViewItem(new[]
                {
            ds.Tables[0].Rows[i]["NAME"].ToString(),
            ds.Tables[0].Rows[i]["ROOMNUM"].ToString(),
            ds.Tables[0].Rows[i]["PRICE"].ToString(),
            ds.Tables[0].Rows[i]["MAX_CLIENT"].ToString(),
            ds.Tables[0].Rows[i]["NOTICE"].ToString()
        });

                // 이미지 인덱스를 설정합니다. 데이터셋의 인덱스에 1을 더한 값을 사용합니다.
                // 0번 인덱스는 빈 이미지이므로, 실제 이미지 인덱스는 1부터 시작합니다.
                item.ImageIndex = i + 1;

                // ListView에 ListViewItem을 추가합니다.
                listView.Items.Add(item);
            }
        }


    }
    public class FAQ
    {
        public int FAQNum;
        public string Question;
        public string Answer;

        public FAQ(int FAQNum, string Question, string Answer)
        {
            this.FAQNum = FAQNum; this.Question = Question; this.Answer = Answer;
        }
    }
}

