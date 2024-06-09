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

        private void Answered_radio_CheckedChanged(object sender, EventArgs e) //답변 완료 라디오 버튼 클릭 시, '답변 완료' 상태의 리스트 출력
        {
            Radio_Answered();
        }

        private void Radio_Answered() //'답변 완료' 상태의 리스트 출력 메소드
        {
            string sql = "SELECT * FROM REQUEST_MANAGE WHERE STATUE='답변 완료'";
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

        private void RequestManageAnswer_btn_Click(object sender, EventArgs e) //리스트 중 하나를 선택하고 답변 버튼 클릭시, 답변 등록 창으로 넘어감
        { //얘네도 컨트롤 클래스에 쑤셔넣어야할듯
            if (RequestManage_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("답변할 요청사항 목록을 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = RequestManage_list.SelectedItems[0]; //답변 상태가 답변 완료인 리스트 선택하고 답변 버튼 클릭시,
            string statue = selectedItem.SubItems[1].Text;
            if (statue == "답변 완료")
            {
                MessageBox.Show("답변 완료된 요청사항입니다!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); //답변 완료된 요청사항이라는 오류 메세지 박스를 출력
                return;
            }

            RequestAnswer_Form requestanswer_form = new RequestAnswer_Form(manager, request);
            requestanswer_form.AnswerSubmitted += RequestAnswer_Form_AnswerSubmitted; // 이벤트 핸들러 추가
            requestanswer_form.ShowDialog();
        }

        private void RequestAnswer_Form_AnswerSubmitted(object sender, EventArgs e)
        {
            RequestManage_ListView_Show(); // 리스트뷰 새로 고침
        }

        private void RequestManagetoMainRequestUI_btn_Click(object sender, EventArgs e) //클릭시, 관리자 메인화면 폼으로 넘어감
        {
            Close();
        }

        private void ToFAQ_btn_Click(object sender, EventArgs e) //FAQ 관리 창으로 넘어감
        {
            FAQ_Manage_Form faq_manage_form = new FAQ_Manage_Form();
            faq_manage_form.Show();
        }

        private void RequestManage_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (RequestManage_list.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = RequestManage_list.SelectedItems[0];
                request = new Request(
                        int.Parse(selectedItem.SubItems[0].Text), // SNum
                        selectedItem.SubItems[1].Text, // Statue
                        selectedItem.SubItems[2].Text, // CID
                        int.Parse(selectedItem.SubItems[3].Text), // Roomnum
                        DateTime.Parse(selectedItem.SubItems[4].Text), // WriteDate
                        selectedItem.SubItems[5].Text, // RequestKind
                        selectedItem.SubItems[6].Text, // Content
                        selectedItem.SubItems[7].Text, // Mid
                        null, // AnswerDate
                        selectedItem.SubItems[9].Text // Answer
                    );
                if (selectedItem.SubItems[8].Text != "")
                {
                    request.AnswerDate = DateTime.Parse(selectedItem.SubItems[8].Text);
                }
            }
        }

    }
}
