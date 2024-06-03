using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class FAQ_Manage_Form : Form
    {
        //string connectionString = "User Id=<admin>;Password=<1562>;DataSource=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=gyeongmin2022.kro.kr)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)))";
        //OracleConnection conn;
        //OracleCommand cmd;
        public FAQ_Manage_Form()
        {
            InitializeComponent();
        }

        private void FAQ_Manage_Form_Load(object sender, EventArgs e)
        {
            FAQ_ListView();
        }
        private void FAQEnroll_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FAQQuestionContent_txt.Text))
            {
                MessageBox.Show("자주 묻는 질문을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(FAQAnswerContent_txt.Text))
            {
                MessageBox.Show("자주 묻는 질문에 대한 답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FAQEnroll();
            }
        }
        private void FAQEnroll()  //FAQ DB에 등록하는 함수
        {
            string Question = FAQQuestionContent_txt.Text;
            string Answer = FAQAnswerContent_txt.Text;

            string sql = "INSERT INTO FAQLIST (QUESTION, ANSWER) VALUES (:QUESTION,:ANSWER)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("QUESTION", OracleDbType.Varchar2, Question, ParameterDirection.Input),
                new OracleParameter("ANSWER", OracleDbType.Varchar2, Answer, ParameterDirection.Input)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
            }
            catch (Exception)
            {
                MessageBox.Show("FAQ가 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("FAQ가 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FAQ_ListView();
        }

        private void FAQ_ListView()
        {
            string sql = "SELECT * FROM FAQLIST ORDER BY FAQNUM";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            FAQ_list.Items.Clear(); // 기존 항목을 지웁니다.

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["FAQNUM"].ToString()); // 첫 번째 컬럼의 값을 사용합니다.
                item.SubItems.Add(row["Question"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());// 두 번째 컬럼의 값을 사용합니다.
                                                             // 추가적인 컬럼이 있으면 여기에 추가합니다.
                FAQ_list.Items.Add(item);
            }
        }

        private void FAQFix_btn_Click(object sender, EventArgs e)
        {
            // 수정 버튼 클릭 로직
        }

        private void FAQFix()
        {

        }

        private void FAQDel_btn_Click(object sender, EventArgs e)//FAQ 삭제 버튼
        {
            
        }

        private void FAQDel()
        {
            if (FAQ_list.SelectedIndices.Count > 0)
            {
                for (int i = FAQ_list.SelectedIndices.Count - 1; i >= 0; i--)
                    FAQ_list.Items.RemoveAt(FAQ_list.SelectedIndices[i]);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.");
            }
        }

        private void FAQ_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

