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
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            if (string.IsNullOrWhiteSpace(RequestAnswer_txt.Text))  //요청사항에 대한 답변을 적지 않고 답변등록 버튼 클릭시,
            {
                MessageBox.Show("답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); //오류메세지 박스 출력
            }
            else //답변을 작성하고 답변 등록 버튼 클릭했을 경우,
            {
                RequestAnswerEnroll();//DB에 요청사항에 대한 답변 삽입
            }
        }

        private void RequestAnswerEnroll() //DB에 요청사항에 대한 답변 등록하는 메소드
        {
            DateTime AnswerDate = DateTime.Now;
            string Answer = RequestAnswer_txt.Text;

            string sql = "UPDATE REQUEST_MANAGE SET STATUE=:STATUE, MID=:MID, ANSWERDATE=:ANSWERDATE, ANSWER=:ANSWER WHERE SNUM = :SNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
               new OracleParameter("STATUE","답변 완료"),
               new OracleParameter("MID",manager.Id),
                new OracleParameter("ANSWERDATE", AnswerDate),
                new OracleParameter("ANSWER", Answer),
                new OracleParameter("SNUM",request.SNum)
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
            Close();//폼 닫기
        }

        private void RequestAnswer_Form_Load(object sender, EventArgs e)
        {
            RequestContentReadOnly_txt.Text = request.Content;
        }
    }
}
