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
    public partial class Reservcheck_Form : Form
    {
        Reserve reserve;
        Client client;
        public Reservcheck_Form(Client client, Reserve reserve)
        {
            InitializeComponent();
            this.reserve = reserve;
            this.client = client;
            Reserve_set(reserve);
        }

        public void Reserve_set(Reserve reserve)
        { 
            string[] phoneNumberSplit =reserve.Tell.Split('-');
            if (phoneNumberSplit[0] == "010") { Tell_cbb.SelectedIndex = 0; }
            else { Tell_cbb.SelectedIndex=1; }

            KRname_txt.Text = reserve.Name_KR;
            ENGname_txt.Text = reserve.Name_ENG;
            Email_txt.Text = reserve.Email;
            Tell_txt.Text = "-"+phoneNumberSplit[1] + "-" + phoneNumberSplit[2];
            Request_txt.Text = reserve.PRE_REQUEST;

            CKIN_lbl.Text = reserve.CKIN.ToString("MM월 dd일 (ddd)");
            CKOUT_lbl.Text = reserve.CKOUT.ToString("MM월 dd일 (ddd)");
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Reservcheck_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reserve_set();
        }
        private void reserve_set()
        {
            if (string.IsNullOrWhiteSpace(KRname_txt.Text) || string.IsNullOrWhiteSpace(ENGname_txt.Text) || string.IsNullOrWhiteSpace(Email_txt.Text) || string.IsNullOrWhiteSpace(Tell_txt.Text))
            {
                MessageBox.Show("올바른 입력정보를 입력하세요");
            }
            else
            {
                reserve.Name_KR = KRname_txt.Text.ToString();
                reserve.Name_ENG = ENGname_txt.Text.ToString();
                reserve.Email = Email_txt.Text.ToString();
                reserve.Tell = Tell_cbb.Text.ToString() + Tell_txt.Text.ToString();
                reserve.ID = client.ID.ToString();
                reserve.PRE_REQUEST = Request_txt.Text.ToString();

                if (!reserve.IsValidEmail(reserve.Email)) { MessageBox.Show("E-mail 형식이 다릅니다."); return; }
                if (reserve.TellNumCkeck(reserve.Tell.ToString()) == 1) { MessageBox.Show("전화번호 형식이 다릅니다."); return; }
                else if (reserve.TellNumCkeck(reserve.Tell.ToString()) == 2) { MessageBox.Show("전화번호 자릿수가 맞지 않습니다."); return; }

                reserve.reserve_retouch();

                MessageBox.Show("수정 완료");
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reserve.reserve_del();
            MessageBox.Show("삭제 완료");
            Close();
        }
    }
}
