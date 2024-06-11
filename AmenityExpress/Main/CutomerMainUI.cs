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
        Client client;
        Reserve reserve;
        public CustomerMainUI(Client client)
        {
            InitializeComponent();
            this.client = client;
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

        private void CustomerUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //예약 조회 넘어가는 버튼임
        {
            Reservlist_Form reservlist_form = new Reservlist_Form(client,false); //고객이기 때문에 false 관리자면 true
            reservlist_form.Owner = this;
            reservlist_form.ShowDialog();
        }

        private void Notice_btn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberInformFix memberInformFix = new MemberInformFix(client);
            memberInformFix.Owner = this;
            memberInformFix.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RequestCheck_Click(object sender, EventArgs e) //요청사항 조회 버튼 클릭시 이동
        {
            RequestList_Form requestlist_form = new RequestList_Form();
            requestlist_form.Owner = this;
            requestlist_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            reserve = new Reserve("", "", "", "", "", dateTimePicker1.Value, dateTimePicker2.Value, 6, "");
            reserve.CKIN = dateTimePicker1.Value;
            reserve.CKOUT = dateTimePicker2.Value;
            if (DateTime.Parse(reserve.CKIN.ToString("MM-dd")) >= DateTime.Parse(reserve.CKOUT.ToString("MM-dd"))) { MessageBox.Show("체크인과 체크아웃의 날짜가 같을 수 없습니다."); return; }
            RoomCheck roomcheck = new RoomCheck(client, reserve);
            this.Visible = false;
            roomcheck.Owner = this;
            roomcheck.ShowDialog();
            this.Visible = true;
        }
    }
}
