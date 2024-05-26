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
        public Manager(string Name, string Id, string Pwd, string Email, string Tel)
        {
            this.Name = Name; this.Id = Id; this.Pwd = Pwd; this.Email = Email; this.Tel = Tel;
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
        public Client(string Name, string ID, string PW, string Email, string Tell, string Sex, string Birth, int Point)
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
        public string CKIN;
        public string CKOUT;
        public int RoomNum;
        public int SNUM;

        public Reserve(string Name_KR, string Name_ENG, string Tell, string Email, string ID, string CKIN, string CKOUT, int RoomNum, int SNUM)
        {
            this.Name_KR = Name_KR; this.Name_ENG = Name_ENG; this.Tell = Tell; this.Email = Email; this.ID = ID; this.CKIN = CKIN; this.CKOUT = CKOUT; this.RoomNum = RoomNum; this.SNUM = SNUM;
        }
    }

    public class Request
    {
        public int SNum;
        public string Client_Id;
        public string Client_Name;
        public string Manager_Id;
        public string Manager_Name;
        public string Detail;
        public string Answer;
        public string Date;
        public string Amenities;
        public string RoomService;

        public Request(int SNum, string Client_Id, string Manager_Id, string Manager_Name, string Detail, string Answer, string Date,
            string Amenities, string RoomService)
        {
            this.SNum = SNum; this.Client_Id = Client_Id; this.Manager_Id = Manager_Id; this.Manager_Name = Manager_Name; this.Detail = Detail;
            this.Answer = Answer; this.Date = Date; this.Amenities = Amenities; this.RoomService = RoomService;
        }
    }

    public class Room
    {
        public int Num;
        public string Name;
        public int MaxP;
        public int Price;
        public string Notice;


        public Room(int Num, string Name, int MaxP, int Price, string Notice)
        {
            this.Num = Num; this.Name = Name; this.MaxP = MaxP; this.Price = Price; this.Notice = Notice;
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

