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

namespace AmenityExpress
{
    public partial class MemberInformFix : Form
    {
        private Client client;

        public MemberInformFix(Client client)
        {
            InitializeComponent();
            this.client = client;
            this.Load += new EventHandler(MemberInformFix_Load); // Load 이벤트 핸들러 연결
        }

        private void MemberInformFix_Load(object sender, EventArgs e)
        {
            LoadMemberInfo();
            ID_txt.ReadOnly = true;
        }

        private void LoadMemberInfo()
        {
            string query = "SELECT ID, NAME, PW, EMAIL, TEL, GENDER, BIRTH, POINT FROM MEMBER_CLIENT WHERE ID = :ID";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("ID", client.ID)
            };

            DataSet ds = DBConnector.DML_QUERY(query, parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                client = new Client(
                    row["ID"].ToString(),
                    row["NAME"].ToString(),
                    row["PW"].ToString(),
                    row["EMAIL"].ToString(),
                    row["TEL"].ToString(),  
                    row["GENDER"].ToString(),
                    Convert.ToDateTime(row["BIRTH"]).ToString("yyyy-MM-dd"),
                    Convert.ToInt32(row["POINT"])
                );

                ID_txt.Text = client.ID;
                Name_txt.Text = client.Name;
                PW_txt.Text = client.PW;
                PWC_txt.Text = client.PW;
                Email_txt.Text = client.Email;
                Tel_txt.Text = client.Tell;  
                Birth_txt.Text = client.Birth;
                if (client.Sex == "남")
                {
                    male_Rbtn.Checked = true;
                }
                else
                {
                    female_Rbtn.Checked = true;
                }
            }
        }

        private void Fix_btn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveMemberInfo();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(Name_txt.Text) ||
                string.IsNullOrEmpty(PW_txt.Text) || string.IsNullOrEmpty(PWC_txt.Text) ||
                string.IsNullOrEmpty(Email_txt.Text) || string.IsNullOrEmpty(Tel_txt.Text) ||
                string.IsNullOrEmpty(Birth_txt.Text))
            {
                MessageBox.Show("모든 필드를 채워주세요.");
                return false;
            }

            if (PW_txt.Text != PWC_txt.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return false;
            }

            if (!Email_txt.Text.Contains("@"))
            {
                MessageBox.Show("올바른 이메일 형식을 입력해주세요.");
                return false;
            }

            if (Tel_txt.Text.Length != 13 || !System.Text.RegularExpressions.Regex.IsMatch(Tel_txt.Text, @"^\d{3}-\d{4}-\d{4}$"))
            {
                MessageBox.Show("전화번호 형식이 올바르지 않습니다. 예: 010-1234-5678");
                return false;
            }

            if (PW_txt.Text.Length <= 4)
            {
                MessageBox.Show("비밀번호는 4자 이상이어야 합니다.");
                return false;
            }

            return true;
        }

        private void SaveMemberInfo()
        {
            string query = "UPDATE MEMBER_CLIENT SET NAME = :Name, PW = :PW, EMAIL = :Email, TEL = :Tel, BIRTH = :Birth, GENDER = :Gender WHERE ID = :ID";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("Name", Name_txt.Text),
                new OracleParameter("PW", PW_txt.Text),
                new OracleParameter("Email", Email_txt.Text),
                new OracleParameter("Tel", Tel_txt.Text),  
                new OracleParameter("Birth", DateTime.Parse(Birth_txt.Text)),
                new OracleParameter("Gender", male_Rbtn.Checked ? "남" : "여"),
                new OracleParameter("ID", ID_txt.Text)
            };

            try
            {
                DBConnector.DML_NON_QUERY(query, parameters);
                MessageBox.Show("회원 정보가 성공적으로 수정되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("회원 정보 수정 중 오류가 발생했습니다: " + ex.Message);
            }
        }
    }
}


