using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class CustomerMainUI : Form
    {
        Client client = new Client("", "", "", "", "", "", "", 0);
        public CustomerMainUI(DataRow row)
        {
            InitializeComponent();
            clientset(row);
            maskedTextBox1.Text = "어서오세요 " + client.Name + "님 잔여 마일리지 : " + client.Point + "p ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CustomerMainUI_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve("", "", "", "", "", DateTime.Today, DateTime.Today, 810, "");
            reserve.CKIN = dateTimePicker1.Value;
            reserve.CKOUT = dateTimePicker2.Value;
            if (reserve.CKIN.ToString("MM-dd") == reserve.CKOUT.ToString("MM-dd")) { MessageBox.Show("체크인과 체크아웃의 날짜가 같을 수 없습니다."); return; }
            RoomSearch_Form roomserch = new RoomSearch_Form(client, reserve);
            this.Visible = false;
            roomserch.Owner = this;
            roomserch.ShowDialog();
            this.Visible = true;
        }
        public void clientset(DataRow row) 
        { 
            client.ID = row[0].ToString();
            client.Name = row[1].ToString();
            client.PW = row[2].ToString();
            client.Email = row[3].ToString();
            client.Tell = row[4].ToString();
            client.Sex = row[5].ToString();
            client.Birth = row[6].ToString();
            client.Point = Convert.ToInt32(row[7].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservlist_Form reservelist = new Reservlist_Form(client, false);
            this.Visible = false;
            reservelist.Owner = this;
            reservelist.ShowDialog();
            this.Visible = true;
        }
    }
}
