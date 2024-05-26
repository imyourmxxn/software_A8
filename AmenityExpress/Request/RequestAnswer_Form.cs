using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class RequestAnswer_Form : Form
    {
        public RequestAnswer_Form()
        {
            InitializeComponent();
        }

        private void RequestAnswerEnroll_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RequestAnswer_txt.Text)) 
            {
                MessageBox.Show("답변을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // 등록 로직을 여기에 추가하세요.
                MessageBox.Show("답변이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //요청사항 내용 textbox는 ReadOnly로 설정해뒀음
            }
        }

        private void RequestAnswerBack_btn_Click(object sender, EventArgs e) //관리자 요청사항 답변 폼에서 뒤로가기 버튼 클릭하면,
                                                                             //요청사항 메인화면으로 넘어감
        {
            RequestManage_Form requestmanage_form = new RequestManage_Form();
            requestmanage_form.Show();
            //뒤에 폼은 닫히는 기능 추가해야함!!!!!
        }
    }
}
