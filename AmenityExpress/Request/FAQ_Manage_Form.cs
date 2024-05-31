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
        private void FAQEnroll()
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
            if (FAQ_list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = FAQ_list.SelectedItems[0];
                int roomNum = int.Parse(selectedItem.SubItems[1].Text);

                DeleteRoom(roomNum);

                listView1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
            //if (FAQ_list.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = FAQ_list.SelectedItems[0];

            //    FAQ_list.Items.Remove(selectedItem);

            //}
            //else
            //{
            //    MessageBox.Show("삭제할 항목을 선택하세요.");
            //}
        }

        private void FAQDel()
        {

        }


        private void FAQ_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

