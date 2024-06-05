using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AmenityExpress
{
    public partial class ClientInformMangement : Form
    {
        DataSet ds;
        public ClientInformMangement()
        {
            InitializeComponent();
            male_RBtn.Checked = true;
            LoadData();
        }
        private void LoadData()
        {
            ds = DBConnector.DML_QUERY("SELECT * FROM ADMIN.MEMBER_CLIENT",null);
            Profile_view.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)//추가버튼
        {
            string id = ID_txt.Text;
            string name = name_txt.Text;
            string pw = PW_txt.Text;
            string email = email_txt.Text;
            string tel = tel_txt.Text;
            string gender = male_RBtn.Checked ? "남" : "여";
            DateTime birth = DateTime.Parse(birth_txt.Text);
            int point = 0; 

            string sql = $"INSERT INTO ADMIN.MEMBER_CLIENT (ID, NAME, PW, EMAIL, TEL, GENDER, BIRTH, POINT) VALUES ('{id}', '{name}', '{pw}', '{email}', '{tel}', '{gender}', TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), {point})";
            DBConnector.DML_NON_QUERY(sql,null);
            LoadData();
        } 

        private void button2_Click(object sender, EventArgs e)//수정버튼
        {
            string id = ID_txt.Text;
            string name = name_txt.Text;
            string pw = PW_txt.Text;
            string email = email_txt.Text;
            string tel = tel_txt.Text;
            string gender = male_RBtn.Checked ? "남" : "여";
            DateTime birth = DateTime.Parse(birth_txt.Text);
            int point = 0;


            string sql = $"UPDATE ADMIN.MEMBER_CLIENT SET NAME='{name}', PW='{pw}', EMAIL='{email}', TEL='{tel}', GENDER='{gender}', BIRTH=TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), POINT={point} WHERE ID='{id}'";
            DBConnector.DML_NON_QUERY(sql, null);
            LoadData();
        }
        private void button3_Click(object sender, EventArgs e)//삭제버튼
        {
            // DataGridView에서 선택된 행을 가져옵니다.
            DataGridViewRow selectedRow = Profile_view.CurrentRow;

            if (selectedRow != null)
            {
                // 선택된 행의 인덱스를 가져옵니다.
                int rowIndex = selectedRow.Index;

                // 선택된 행의 ID 값을 가져옵니다.
                string id = selectedRow.Cells["ID"].Value.ToString();

                // 선택된 행을 DataGridView에서 제거합니다.
                Profile_view.Rows.RemoveAt(rowIndex);

                // 데이터베이스에서 선택된 행을 삭제합니다.
                string sql = $"DELETE FROM ADMIN.MEMBER_CLIENT WHERE ID='{id}'";
                DBConnector.DML_NON_QUERY(sql, null);
            }
        }




        private void Member_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string searchValue = Search_txt.Text;
            string sql = $"SELECT * FROM ADMIN.MEMBER_CLIENT WHERE ID LIKE '%{searchValue}%' OR NAME LIKE '%{searchValue}%' OR PW LIKE '%{searchValue}%' OR EMAIL LIKE '%{searchValue}%' OR TEL LIKE '%{searchValue}%' OR GENDER LIKE '%{searchValue}%' OR BIRTH LIKE '%{searchValue}%'";

            ds = DBConnector.DML_QUERY(sql, null);
            Profile_view.DataSource = ds.Tables[0];
        }
        private void Profile_view_SelectionChanged(object sender, EventArgs e)
        {
            if (Profile_view.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Profile_view.SelectedRows[0];
                ID_txt.Text = row.Cells["ID"].Value.ToString();
                name_txt.Text = row.Cells["NAME"].Value.ToString();
                PW_txt.Text = row.Cells["PW"].Value.ToString();
                email_txt.Text = row.Cells["EMAIL"].Value.ToString();
                tel_txt.Text = row.Cells["TEL"].Value.ToString();
                birth_txt.Text = row.Cells["BIRTH"].Value.ToString();

                string gender = row.Cells["GENDER"].Value.ToString();
                if (gender == "남")
                {
                    male_RBtn.Checked = true;
                }
                else if (gender == "여")
                {
                    female_Rbtn.Checked = true;
                }
            }
        }
        private void Profile_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행이 선택되었는지 확인
            {
                DataGridViewRow row = Profile_view.Rows[e.RowIndex];

                // 각 셀의 값을 TextBox에 설정
                ID_txt.Text = row.Cells["ID"].Value.ToString();
                name_txt.Text = row.Cells["NAME"].Value.ToString();
                PW_txt.Text = row.Cells["PW"].Value.ToString();
                email_txt.Text = row.Cells["EMAIL"].Value.ToString();
                tel_txt.Text = row.Cells["TEL"].Value.ToString();
                // 성별을 라디오 버튼에 설정
                string gender = row.Cells["GENDER"].Value.ToString();
                if (gender == "남")
                    male_RBtn.Checked = true;
                else if (gender == "여")
                    female_Rbtn.Checked = true;
                // 생년월일은 DateTimePicker에 설정
                birth_txt.Text = row.Cells["BIRTH"].Value.ToString();
            }
        }
        private void InitializeDataGridView()
        {
            // 열을 자동으로 생성하지 않도록 설정
            Profile_view.AutoGenerateColumns = false;

            // ID 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "아이디",
                Name = "ID"
            });

            // Name 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NAME",
                HeaderText = "이름",
                Name = "NAME"
            });

            // Password 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PW",
                HeaderText = "비밀번호",
                Name = "PW"
            });

            // Email 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EMAIL",
                HeaderText = "이메일",
                Name = "EMAIL"
            });

            // Tel 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TEL",
                HeaderText = "전화번호",
                Name = "TEL"
            });

            // Gender 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GENDER",
                HeaderText = "성별",
                Name = "GENDER"
            });

            // Birth 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BIRTH",
                HeaderText = "생년월일",
                Name = "BIRTH"
            });

            // Point 열 추가
            Profile_view.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "POINT",
                HeaderText = "포인트",
                Name = "POINT"
            });
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
