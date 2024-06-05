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

        private void RequestListFAQ_btn_Click(object sender, EventArgs e)//FAQ 폼으로 넘어가기
        {
            FAQ_Form faq_form = new FAQ_Form(); 
            faq_form.Show();
        }
        private void RequestEnroll_ListView_Show()
        {
            string sql = "SELECT * FROM REQUEST_MANAGE ORDER BY SNUM";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            RequestList_list.Items.Clear(); // 기존 항목을 지우기

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["SNUM"].ToString()); // 첫 번째 컬럼의 값을 사용합니다.
                item.SubItems.Add(row["STATUE"].ToString());
                item.SubItems.Add(row["CID"].ToString());
                item.SubItems.Add(row["ROOMNUM"].ToString());
                item.SubItems.Add(row["WRITEDATE"].ToString());
                item.SubItems.Add(row["REQUESTKIND"].ToString());
                item.SubItems.Add(row["CONTENT"].ToString());
                item.SubItems.Add(row["MID"].ToString());
                item.SubItems.Add(row["ANSWERDATE"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());// 두 번째 컬럼의 값을 사용합니다.

                RequestList_list.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RequestListBack_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RequestList_Form_Load(object sender, EventArgs e)
        {
            RequestEnroll_ListView_Show();
        }
    }
}
