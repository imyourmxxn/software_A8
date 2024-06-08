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

namespace AmenityExpress
{
    public partial class FAQ_Manage_Form : Form
    {
        FAQ faq;
        public FAQ_Manage_Form()
        {
            InitializeComponent();
        }

        private void FAQ_Manage_Form_Load(object sender, EventArgs e) //FAQ 리스트뷰 출력
        {
            faq = new FAQ(0,"","");
            FAQEnroll_ListView_Show();
        }

        private void FAQEnroll_btn_Click(object sender, EventArgs e) //등록버튼 클릭 시,
        {
            if (string.IsNullOrWhiteSpace(FAQQuestionContent_txt.Text)) //FAQ 질문 칸이 공백일 시, 오류메세지 출력
            {
                MessageBox.Show("자주 묻는 질문을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(FAQAnswerContent_txt.Text)) //답변 칸이 공백일 시, 오류메세지 출력
            {
                MessageBox.Show("자주 묻는 질문에 대한 답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //질문, 답변 칸이 공백이 아닐 시,
            {
                FAQEnroll(); //DB에 질문, 답변 삽입하는 함수 적용
            }
        }

        private void FAQEnroll()  //FAQ DB에 등록하는 함수
        {
            string Question = FAQQuestionContent_txt.Text;
            string Answer = FAQAnswerContent_txt.Text;

            string sql = "INSERT INTO FAQLIST (QUESTION, ANSWER) VALUES (:QUESTION,:ANSWER)"; //DB INSERT문
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("QUESTION", OracleDbType.Varchar2, Question, ParameterDirection.Input),
                new OracleParameter("ANSWER", OracleDbType.Varchar2, Answer, ParameterDirection.Input)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters); //INSERT, DELETE, UPDATE문 사용 시 쓰는 메소드
            }
            catch (Exception) //메소드가 제대로 작동되지 않으면 오류 메세지 출력
            {
                MessageBox.Show("FAQ가 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //RETRUN문을 써서 등록 실패 메세지 출력에서 마침
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
                item.SubItems.Add(row["QUESTION"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());// 두 번째 컬럼의 값을 사용합니다.

                FAQ_list.Items.Add(item);
            }
        }

        private void FAQFix_btn_Click(object sender, EventArgs e) //수정 버튼 클릭 시
        {
            if (FAQ_list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = FAQ_list.SelectedItems[0];
                faq.FAQNum = int.Parse(selectedItem.SubItems[0].Text);
                faq.Question = FAQQuestionContent_txt.Text;
                faq.Answer = FAQAnswerContent_txt.Text;

                FAQFix();
            }
            else
            {
                MessageBox.Show("수정할 FAQ를 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FAQFix() //DB FAQ 데이터 수정 메소드
        {
            string sql = "UPDATE FAQLIST SET QUESTION=:QUESTION, ANSWER=:ANSWER WHERE FAQNUM=:FAQNUM";
            OracleParameter[] parameters = new OracleParameter[]
           {
                new OracleParameter("QUESTION", faq.Question),
                new OracleParameter("ANSWER", faq.Answer),
                new OracleParameter("FAQNUM", faq.FAQNum)
           };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("선택하신 FAQ가 수정되었습니다!", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FAQEnroll_ListView_Show(); // 리스트뷰 새로고침
            }
            catch (Exception)
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
            string sql = "DELETE FROM FAQLIST WHERE FAQNUM=:FAQNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("FAQNUM", num)
            };

            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("선택하신 FAQ가 삭제되었습니다!", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
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

        private void FAQManageBack_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


