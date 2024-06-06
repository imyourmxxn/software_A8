using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class RequestManage_Form : Form
    {
        Manager manager;
        Request request;
        FAQ faq;
        public RequestManage_Form(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

     
        private void RequestManage_ListView_Show() //요청사항 리스트뷰 출력 메소드
        {
            string sql = "SELECT * FROM REQUEST_MANAGE ORDER BY SNUM";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            RequestManage_list.Items.Clear(); // 기존 항목 지우기

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

                RequestManage_list.Items.Add(item);
            }
        }

        private void RequestManage_Form_Load(object sender, EventArgs e) //요청사항 리스트뷰 출력
        {
            RequestManage_ListView_Show();
        }

        private void TotalAnswer_radio_CheckedChanged(object sender, EventArgs e) //전체 답변 라디오버튼 클릭시, 전체 답변 출력
        {
            RequestManage_ListView_Show();
        }


        private void UnAnswered_radio_CheckedChanged(object sender, EventArgs e)//답변 전 라디오 버튼 클릭시, 답변 상태가 '답변 전'인 리스트만 뽑아서 출력
        {
            Radio_Unanswered();
        }
        private void Radio_Unanswered() //답변 상태가 '답변 전'인 리스트만 뽑아서 출력하는 메소드
        {
            string sql = "SELECT * FROM REQUEST_MANAGE WHERE STATUE='답변 전'";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            RequestManage_list.Items.Clear(); // 기존 항목 지우기

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["SNUM"].ToString()); //첫번째 칼럼 값 사용
                item.SubItems.Add(row["STATUE"].ToString());
                item.SubItems.Add(row["CID"].ToString());
                item.SubItems.Add(row["ROOMNUM"].ToString());
                item.SubItems.Add(row["WRITEDATE"].ToString());
                item.SubItems.Add(row["REQUESTKIND"].ToString());
                item.SubItems.Add(row["CONTENT"].ToString());
                item.SubItems.Add(row["MID"].ToString());
                item.SubItems.Add(row["ANSWERDATE"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());

                RequestManage_list.Items.Add(item);
            }
        }


        private void Answered_radio_CheckedChanged(object sender, EventArgs e) //답변 완료 라디오 버튼 클릭 시, '답변 완료' 상태의 리스트 출력
        {
            Radio_Answered();
        }
        private void Radio_Answered()//'답변 완료' 상태의 리스트 출력 메소드
        {
            string sql = "SELECT * FROM REQUEST_MANAGE WHERE STATUE='답변 완료'";
            DataSet dbconnector = DBConnector.DML_QUERY(sql, null);

            RequestManage_list.Items.Clear(); // 기존 항목 지우기

            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["SNUM"].ToString()); // 첫 번째 컬럼 값 사용
                item.SubItems.Add(row["STATUE"].ToString());
                item.SubItems.Add(row["CID"].ToString());
                item.SubItems.Add(row["ROOMNUM"].ToString());
                item.SubItems.Add(row["WRITEDATE"].ToString());
                item.SubItems.Add(row["REQUESTKIND"].ToString());
                item.SubItems.Add(row["CONTENT"].ToString());
                item.SubItems.Add(row["MID"].ToString());
                item.SubItems.Add(row["ANSWERDATE"].ToString());
                item.SubItems.Add(row["ANSWER"].ToString());

                RequestManage_list.Items.Add(item);
            }
        }



        private void RequestManageAnswer_btn_Click(object sender, EventArgs e) //리스트 중 하나를 선택하고 답변 버튼 클릭시, 답변 등록 창으로 넘어감
        {
            if (RequestManage_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("답변할 요청사항 목록을 선택하세요!","오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            RequestAnswer_Form requestanswer_form = new RequestAnswer_Form(manager, request);
            requestanswer_form.ShowDialog();
        }

        private void RequestManagetoMainRequestUI_btn_Click(object sender, EventArgs e) //클릭시, 관리자 메인화면 폼으로 넘어감
        {
            Close();
        }

        private void ToFAQ_btn_Click(object sender, EventArgs e) //FAQ 관리 창으로 넘어감
        {
            FAQ_Manage_Form faq_manage_form = new FAQ_Manage_Form(faq);
            faq_manage_form.Show();
        }


        private void RequestManage_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (RequestManage_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("답변할 요청사항 목록을 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            request = new Request(int.Parse(RequestManage_list.SelectedItems[0].SubItems[0].Text), RequestManage_list.SelectedItems[0].SubItems[1].Text, RequestManage_list.SelectedItems[0].SubItems[2].Text,
                int.Parse(RequestManage_list.SelectedItems[0].SubItems[3].Text), RequestManage_list.SelectedItems[0].SubItems[4].Text, RequestManage_list.SelectedItems[0].SubItems[5].Text, RequestManage_list.SelectedItems[0].SubItems[6].Text,
                RequestManage_list.SelectedItems[0].SubItems[7].Text, RequestManage_list.SelectedItems[0].SubItems[8].Text, RequestManage_list.SelectedItems[0].SubItems[9].Text);
        }
    }
}
