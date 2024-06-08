using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress.RoomManagement
{
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
}
