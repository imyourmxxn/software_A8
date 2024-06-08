using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
        public Manager(string Id, string Name, string Pwd, string Email, string Tel, string Gender,string Birthday)
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
        public Client(string ID,string Name , string PW, string Email, string Tell, string Sex, string Birth, int Point)
        {
            this.Name = Name; this.ID = ID; this.PW = PW; this.Email = Email; this.Tell = Tell; this.Sex = Sex; this.Birth = Birth; this.Point = Point;
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
    }

    public class Request
    {
        public int SNum;
        public string Statue;
        public string RequestKind;
        public string Content;
        public string WriteDate;
        public string Answer;
        public string AnswerDate;
        public string Cid;
        public string Mid;
        public int Roomnum;

        public Request(int SNum, string Statue, string Cid,int Roomnum,string WriteDate,string RequestKind, string Content, string Mid, string AnswerDate, string Answer)
        {
            this.SNum = SNum;
            this.Statue = Statue;
            this.RequestKind = RequestKind;
            this.Content = Content;
            this.Answer = Answer;
            this.Cid = Cid;
            this.Mid = Mid;
            this.Roomnum = Roomnum;
            this.WriteDate = WriteDate;
            this.AnswerDate = AnswerDate;
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


        public Room(int Num, string Name, int MaxP, int Price, string Notice,string imagePath)
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

            // 이미지 리스트 생성
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50); // 이미지 크기 조정 (가로, 세로)

            // 이미지를 표시할 이미지 리스트에 이미지 추가
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string imagePath = ds.Tables[0].Rows[i]["PHOTOPATH"].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        // 이미지 리스트에 이미지 추가
                        imageList.Images.Add(Image.FromFile(imagePath));
                    }
                    catch (Exception ex)
                    {
                        // 이미지 로드 실패 시 처리할 내용
                        Console.WriteLine($"이미지 로드 실패: {ex.Message}");
                    }
                }
            }

            // 리스트뷰에 이미지 리스트 연결
            listView.SmallImageList = imageList;

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
                item.ImageIndex = i; // 이미지 인덱스 설정
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

