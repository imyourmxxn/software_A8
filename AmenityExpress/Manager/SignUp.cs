using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AmenityExpress
{
    public partial class SignUp : Form
    {
        private bool isAdmin = false;

        public SignUp()
        {
            InitializeComponent();
        }

        private bool SignUpMember(Client client)
        {
            string tableName = isAdmin ? "MEMBER_MANAGER" : "MEMBER_CLIENT";
            string query = $@"INSERT INTO {tableName} (ID, NAME, PW, EMAIL, TEL, GENDER, BIRTH, POINT) 
                              VALUES (:ID, :NAME, :PW, :EMAIL, :TEL, :GENDER, TO_DATE(:BIRTH, 'YYYY-MM-DD'), 0)";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ID", client.ID),
                new OracleParameter("NAME", client.Name),
                new OracleParameter("PW", client.PW),
                new OracleParameter("EMAIL", client.Email),
                new OracleParameter("TEL", client.Tell),
                new OracleParameter("GENDER", client.Sex),
                new OracleParameter("BIRTH", client.Birth)
            };

            try
            {
                DBConnector.DML_NON_QUERY(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("회원가입 중 오류가 발생했습니다. 오류 메시지: " + ex.Message);
                return false;
            }
        }

        private bool IsIdAvailable(string id)
        {
            string query = "SELECT COUNT(*) FROM MEMBER_CLIENT WHERE ID = :ID";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ID", id)
            };

            DataSet result = DBConnector.DML_QUERY(query, parameters);
            int count = Convert.ToInt32(result.Tables[0].Rows[0][0]);
            return count == 0;
        }

        private void doublecheck_btn_Click(object sender, EventArgs e)
        {
            string id = ID_txt.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }

            if (IsIdAvailable(id))
            {
                MessageBox.Show("사용 가능한 아이디입니다.");
            }
            else
            {
                MessageBox.Show("이미 사용 중인 아이디입니다.");
            }
        }

        private void SignUP_btn_Click(object sender, EventArgs e)
        {
            string id = ID_txt.Text;
            string name = Name_txt.Text;
            string pw = PW_txt.Text;
            string email = Email_txt.Text;
            string tel = Tel_txt.Text;
            string gender = male_Rbtn.Checked ? "남" : "여";
            string birth = Birth_txt.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pw) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(birth))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                return;
            }

            if (!IsIdAvailable(id))
            {
                MessageBox.Show("이미 사용 중인 아이디입니다.");
                return;
            }

            Client newClient = new Client(id, name, pw, email, tel, gender, birth, 0);

            if (SignUpMember(newClient))
            {
                MessageBox.Show("회원가입이 완료되었습니다.");
                this.Close(); // 회원가입 성공 시 폼 닫기
            }
            else
            {
                MessageBox.Show("회원가입에 실패했습니다.");
            }
        }

        private void admin_check_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = admin_check.Checked;
        }

        private void user_check_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = !user_check.Checked;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void SignUp_Load(object sender, EventArgs e) { }
    }
}