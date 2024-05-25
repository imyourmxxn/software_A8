using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve
{
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

    public class reserve
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

        public reserve(string Name_KR, string Name_ENG, string Tell, string Email, string ID, string CKIN, string CKOUT, int RoomNum, int SNUM)
        {
            this.Name_KR = Name_KR; this.Name_ENG = Name_ENG; this.Tell = Tell; this.Email = Email; this.ID = ID; this.CKIN = CKIN; this.CKOUT = CKOUT; this.RoomNum = RoomNum; this.SNUM = SNUM;
        }
    }
}
