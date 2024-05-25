using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomManagement
{
    public partial class RoomSearchM_Form : Form
    {
        public RoomSearchM_Form()
        {
            InitializeComponent();

            listView1.Columns.Add("Room Name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Price", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room MaxP", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Room Notice", 150, HorizontalAlignment.Left);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            addButton.Click += new EventHandler(addButton_Click);

        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomSearchM_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (DialogForm dialog = new DialogForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Room room = dialog.RoomData;

                    ListViewItem item = new ListViewItem(new[]
                    {
                        room.Name,
                        room.Num.ToString(),
                        room.Price.ToString(),
                        room.MaxP.ToString(),
                        room.Notice
                    });

                    listView1.Items.Add(item);
                }
            }
        }
    }
}
