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


namespace AmenityExpress
{
    public partial class RequestAnswer_Form : Form
    {
        Manager manager;
        Request request;
        RequestAnswerControl answerControl = new RequestAnswerControl();
        public event EventHandler AnswerSubmitted; // 이벤트 선언
        

        public RequestAnswer_Form(Manager manager, Request request)
        {
            InitializeComponent();
            this.manager = manager;
            this.request = request;
        }

        private void RequestAnswerEnroll_btn_Click(object sender, EventArgs e)
        {
            request.Answer = RequestAnswer_txt.Text;
            request.AnswerDate = DateTime.Now;
            bool result = request.CheckAnswer();
            if (result)
            {
                answerControl.RequestAnswerEnroll(this,manager,request,AnswerSubmitted);
            }
        }

        private void RequestAnswerBack_btn_Click(object sender, EventArgs e) //관리자 요청사항 답변 폼에서 뒤로가기 버튼 클릭하면,
        {
            Close();//폼 닫기
        }

        private void RequestAnswer_Form_Load(object sender, EventArgs e)
        {
            RequestContentReadOnly_txt.Text = request.Content;
        }
    }
}
