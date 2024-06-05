using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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

