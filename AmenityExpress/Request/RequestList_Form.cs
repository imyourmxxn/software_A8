using AmenityExpress;
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
//요청사항 기본화면(고객 입장 -> FAQ 버튼 클릭시, FAQ 조회하는 폼으로 넘어감/
//요청하기 버튼 클릭시, 요청사항 작성하는 폼으로 넘어감
//요청사항 버튼은 클릭 안 해도 그냥 기본화면인데 없어도 될랑가,,
namespace AmenityExpress
{
    public partial class RequestList_Form : Form
    {
        public RequestList_Form()
        {
            InitializeComponent();
        }

        private void RequestListFAQ_btn_Click(object sender, EventArgs e)
        {
            FAQ_Form faq_form = new FAQ_Form(); //FAQ 폼으로 넘어가기
            faq_form.Show();
        }

        private void RequestList_btn_Click(object sender, EventArgs e)
        {

        }

        private void RequestListToWrite_btn_Click(object sender, EventArgs e)
        {
            RequestWrite_Form requestwrite_form = new RequestWrite_Form(); //요청하기 폼으로 넘어가기
            requestwrite_form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RequestListBack_btn_Click(object sender, EventArgs e)
        {
            //객실선택쪽으로 돌아가야하나..
        }

        private void RequestList_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
