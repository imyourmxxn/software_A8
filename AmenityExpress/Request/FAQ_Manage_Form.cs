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
            FAQEnroll_ListView_Show();
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
            FAQEnroll_ListView_Show();
        }

        private void FAQEnroll_ListView_Show()
        {
            string sql = "SELECT * FROM FAQLIST ORDER BY FAQNUM";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            FAQ_list.Items.Clear(); // 기존 항목을 지우기

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["FAQNUM"].ToString()); // 첫 번째 컬럼의 값을 사용합니다.
                item.SubItems.Add(row["Question"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());// 두 번째 컬럼의 값을 사용합니다.
                                                            
                FAQ_list.Items.Add(item);
            }
        }

        private void FAQFix_btn_Click(object sender, EventArgs e) //수정 버튼 클릭 시
        {
                if (FAQ_list.SelectedItems.Count > 0)
                {
                int n = FAQ_list.SelectedItems.Count;
                {
                    FAQFix();
                    FAQ_list.Items[n].SubItems[1].Text = FAQQuestionContent_txt.Text;
                    FAQ_list.Items[n].SubItems[2].Text = FAQAnswerContent_txt.Text;
                }
            }
            else
            {
                MessageBox.Show("수정할 FAQ를 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FAQFix()
        {
            string sql = "UPDATE FROM FAQLIST WHERE FAQLIST";

            try
            {
                DBConnector.DML_NON_QUERY(sql, null);
                MessageBox.Show("선택하신 FAQ가 수정되었습니다!", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAQ가 수정되지 않았습니다!", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FAQDel_btn_Click(object sender, EventArgs e)//FAQ 삭제 버튼 클릭 시
        {
            if (FAQ_list.SelectedIndices.Count > 0)
            {
                for (int i = FAQ_list.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    FAQDel(FAQ_list.SelectedItems[i].SubItems[0].Text);  //DB 데이터 삭제하는 메소드 호출
                    FAQ_list.Items.RemoveAt(FAQ_list.SelectedIndices[i]);
                }
            }
            else
            {
                MessageBox.Show("삭제할 FAQ를 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FAQDel(String num) //DB의 FAQLIST 삭제 메소드
        {
            string sql = "DELETE FROM FAQLIST WHERE FAQNUM="+num;

            try
            {
                DBConnector.DML_NON_QUERY(sql,null);
                MessageBox.Show("선택하신 FAQ가 삭제되었습니다!", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAQ가 삭제되지 않았습니다!", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FAQ_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FAQQuestionContent_txt.Text = FAQ_list.FocusedItem.SubItems[1].Text;
                FAQAnswerContent_txt.Text = FAQ_list.FocusedItem.SubItems[2].Text;
            }

            catch { }
        }
    }
}

