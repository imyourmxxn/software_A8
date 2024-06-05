using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class RequestAnswer_Form : Form
    {
        Manager manager;
        Request request;
        public RequestAnswer_Form(Manager manager, Request request)
        {
            InitializeComponent();
            this.manager = manager;
            this.request = request;
        }

        private void RequestAnswerEnroll_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RequestAnswer_txt.Text)) 
            {
                MessageBox.Show("답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RequestAnswerEnroll();
            }
        }

        private void RequestAnswerEnroll() //DB에 요청사항에 대한 답변 등록하는 메소드
        {
            DateTime AnswerDate = DateTime.Now;
            string Answer = RequestAnswer_txt.Text;

            string sql = "UPDATE REQUEST_MANAGE SET 'STATUE, MID, ANSWERDATE, ANSWER' WHERE (:STATUE, :CID, :ROOMNUM, :WRITEDATE, :REQUESTKIND, :CONTENT, :MID, :ANSWERDATE, :ANSWER)";
            OracleParameter[] parameters = new OracleParameter[]
            {
               new OracleParameter("STATUE", OracleDbType.Varchar2, "답변 완료", ParameterDirection.Input),
                new OracleParameter("CID", OracleDbType.Varchar2, request.Cid, ParameterDirection.Input),
                new OracleParameter("ROOMNUM", OracleDbType.Int32,request.Roomnum, ParameterDirection.Input),
                new OracleParameter("WRITEDATE", OracleDbType.Date, request.WriteDate, ParameterDirection.Input),
                new OracleParameter("REQUESTKIND", OracleDbType.Varchar2, request.RequestKind, ParameterDirection.Input),
                new OracleParameter("CONTENT", OracleDbType.Varchar2, request.Content, ParameterDirection.Input),
                new OracleParameter("MID", OracleDbType.Varchar2, manager.Id, ParameterDirection.Input),
                new OracleParameter("ANSWERDATE", OracleDbType.Date, AnswerDate, ParameterDirection.Input),
                new OracleParameter("ANSWER", OracleDbType.Varchar2, Answer, ParameterDirection.Input)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
            }
            catch
            {
                MessageBox.Show("요청사항에 대한 답변이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("답변이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RequestAnswerBack_btn_Click(object sender, EventArgs e) //관리자 요청사항 답변 폼에서 뒤로가기 버튼 클릭하면,
                                                                             //요청사항 메인화면으로 넘어감
        {
            Close();
            //뒤에 폼은 닫히는 기능 추가해야함!!!!!
        }

        private void RequestAnswer_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestAnswer_Form_Load(object sender, EventArgs e)
        {
            RequestContentReadOnly_txt.Text = request.Content;
        }
    }
}
