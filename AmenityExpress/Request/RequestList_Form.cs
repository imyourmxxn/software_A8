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
//요청사항 고객 기본화면(-> FAQ 버튼 클릭시, FAQ 조회하는 폼으로 넘어감/
//요청하기 버튼 클릭시, 요청사항 작성하는 폼으로 넘어감)
namespace AmenityExpress
{
    public partial class RequestList_Form : Form
    {
        string client_id;
        public RequestList_Form(string client_id)
        {
            InitializeComponent();
            this.client_id = client_id;
        }

        private void RequestEnroll_ListView_Show()
        {//얘도 쑤셔넣어야하나?
            string sql = "SELECT * FROM REQUEST_MANAGE WHERE CID = :CID ORDER BY SNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("CID", client_id)
            };
            DataSet dbconnector = DBConnector.DML_QUERY(sql,parameters);

            RequestList_list.Items.Clear(); // 기존 항목 지우기

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["SNUM"].ToString());
                item.SubItems.Add(row["STATUE"].ToString());
                item.SubItems.Add(row["CID"].ToString());
                item.SubItems.Add(row["ROOMNUM"].ToString());
                item.SubItems.Add(row["WRITEDATE"].ToString());
                item.SubItems.Add(row["REQUESTKIND"].ToString());
                item.SubItems.Add(row["CONTENT"].ToString());
                item.SubItems.Add(row["MID"].ToString());
                item.SubItems.Add(row["ANSWERDATE"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());

                RequestList_list.Items.Add(item);
            }
        }

        private void RequestList_Form_Load(object sender, EventArgs e)//폼에 리스트뷰 띄우기
        {
            RequestEnroll_ListView_Show();
        }


        private void RequestListBack_btn_Click(object sender, EventArgs e) //폼 닫아서 고객 메인ui가 뜸
        {
            Close();
        }

        private void RequestListFAQ_btn_Click(object sender, EventArgs e)//FAQ 폼으로 넘어가기
        {
            FAQ_Form faq_form = new FAQ_Form();
            faq_form.Show();
        }

    }
}
