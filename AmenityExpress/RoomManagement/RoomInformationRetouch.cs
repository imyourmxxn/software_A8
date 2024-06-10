using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmenityExpress.RoomManagement
{
    internal class RoomInformationRetouch
    {
        public static void RetouchRoom(int roomNum, string name, int maxP, int price, string notice, string imagePath)
        {
            Room roomData = new Room(roomNum, name, maxP, price, notice, imagePath);
            roomData.Update_Room(roomData);
        }
    }
}
