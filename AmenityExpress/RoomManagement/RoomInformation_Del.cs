using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress.RoomManagement
{
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
}
