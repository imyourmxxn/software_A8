using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRequest
{
    public class Entity
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
        public int SNum; //예약 번호
        public int RoomNum; //객실 번호
        public string Name;
        public string Id;
        public string Tel;
        public string Email;
        public string CKIN; //체크인 날짜
        public string CKOUT; //체크아웃 날짜

        public Reserve(int SNum, int RoomNum, string Name, string Id, string Tel, string Email, string CKIN, string CKOUT)
        {
            this.SNum = SNum; this.RoomNum = RoomNum; this.Name = Name; this.Id = Id; this.Tel = Tel; this.Email = Email;
            this.CKIN = CKIN; this.CKOUT = CKOUT;
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
}

