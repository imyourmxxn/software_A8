using AmenityExpress.RoomManagement;
using AmenityExpress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;

namespace AmenityExpress
{
    public partial class Reserv_Form : Form
    {
        System.Windows.Forms.TextBox[] txtList;
        const string FirstName = "FIRST NAME(이름)";
        const string LastName = "LAST NAME(성)";
        const string Request = "공항 교통편 문의 또는 호텔 이용 시 문의하실 사항이 있으시면 입력해 주십시오.";

        Client client = null;
        Reserve reserve = null;

        public Reserv_Form()
        {
            InitializeComponent();

            Tell_cbb.SelectedIndex = 0;

            txtList = new System.Windows.Forms.TextBox[] { FirstName_txt, LastName_txt, Request_txt };

            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == FirstName_txt) txt.Text = FirstName;
                else if (txt == LastName_txt) txt.Text = LastName;
                else if (txt == Request_txt) txt.Text = Request;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tell_cbb.SelectedIndex = 0;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (txt.Text == FirstName | txt.Text == LastName | txt.Text == Request)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Font = new Font("맑은 고딕", 17);
                txt.Text = string.Empty;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                txt.Font = new Font("맑은 고딕", 12);
                if (txt == FirstName_txt) txt.Text = FirstName;
                else if (txt == LastName_txt) txt.Text = LastName;
                else if (txt == Request_txt) txt.Text = Request;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserv_btn_Click(object sender, EventArgs e)
        {
            reserve_set();
        }

        private void reserve_set() 
        {
            if (string.IsNullOrWhiteSpace(KRname_txt.Text) || string.IsNullOrWhiteSpace(FirstName_txt.Text) || string.IsNullOrWhiteSpace(LastName_txt.Text) || string.IsNullOrWhiteSpace(Email_txt.Text) || string.IsNullOrWhiteSpace(Tell_txt.Text))
            {
                MessageBox.Show("올바른 입력정보를 입력하세요");
            }
            else if (FirstName_txt.Text == FirstName || LastName_txt.Text == LastName) { MessageBox.Show("올바른 입력정보를 입력하세요"); } 
            else
            { 
                reserve.Name_KR = KRname_txt.Text.ToString();
                reserve.Name_ENG = FirstName_txt.Text.ToString() + LastName_txt.Text.ToString();
                reserve.Email = Email_txt.Text.ToString();
                reserve.Tell = Tell_cbb.Text.ToString() + Tell_txt.Text.ToString();
                reserve.ID = client.ID.ToString();

                reserve_dbset();

                this.Visible = false;
                Pay_Form pay_form = new Pay_Form(client, reserve);
                pay_form.Owner = this;
                pay_form.ShowDialog();
                Close();
            }
        }

        public void reserve_dbset() 
        {
            string query = "INSERT INTO RESERV_MANAGE (ROOMNUM, KR, ENG, ID, TEL, EMAIL, CKIN, CKOUT, SNUM) VALUES (:ROOMNUM, :KR, :ENG, :ID, :TEL, :EMAIL, :CKIN, :CKOUT, :SNUM)";
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ROOMNUM", 103),
                new OracleParameter("KR", reserve.Name_KR),
                new OracleParameter("ENG", reserve.Name_ENG),
                new OracleParameter("ID", reserve.ID),
                new OracleParameter("TEL", reserve.Tell),
                new OracleParameter("EMAIL", reserve.Email),
                new OracleParameter("CKIN", reserve.CKIN),
                new OracleParameter("CKOUT", reserve.CKOUT),
                new OracleParameter("SNUM", null)
            };
            DBConnector.DML_NON_QUERY(query, parameters);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Request_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tell_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cnacel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reserv_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
