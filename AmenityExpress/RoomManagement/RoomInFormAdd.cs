using AmenityExpress;
using AmenityExpress.RoomManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class RoomInFormAdd : Form
    {
        private ListView parentListView;
        public Room RoomData { get; private set; }
        private string selectedImagePath;
        public RoomInFormAdd(ListView listView)
        {
            InitializeComponent();
            this.parentListView = listView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DialogForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            RoomInformationadd.Add_Room(RoomNumTextBox, RoomMaxTextBox, RoomPricetextBox, RoomNameTextBox, RoomNoticeTextBox, selectedImagePath, parentListView);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void RoomPriceLable_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void ImageAddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                RoomPictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
