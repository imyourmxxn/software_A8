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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class RequestWrite_Form : Form
    {
        private string Cid;
        private int RoomNum;
        private void InitailizeComboBox()
        {
            //RequestKind_CmBox.Items.AddRange(new string[] { "객실 상품 교체 요청", "어매니티 요청", "룸 서비스 요청", "기타사항 요청" });
            //RequestKind_CmBox.SelectedIndex = 0;
        }
        public RequestWrite_Form()
        {
            InitializeComponent();
            InitailizeComboBox();

            //this.Load += new EventHandler(Form2_Load);
            // 콤보박스 선택 변경 이벤트 핸들러 연결
            //this.RequestKind_CmBox.SelectedIndexChanged += new EventHandler(RequestKind_CmBox_SelectedIndexChanged);
            //// 버튼 클릭 이벤트 핸들러 연결
            this.RequestWriteEnroll_btn.Click += new EventHandler(RequestWriteEnroll_btn_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RequestKind_CmBox.Items.Add("객실 상품 교체 요청");
            RequestKind_CmBox.Items.Add("어매니티 요청");
            RequestKind_CmBox.Items.Add("룸 서비스 요청");
            RequestKind_CmBox.Items.Add("기타사항 요청");
        }

        private void RequestKind_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RequestContent_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestWriteEnroll_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RequestKind_CmBox.Text))
            {
                MessageBox.Show("요청사항 종류를 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(RequestContent_txt.Text))
            {
                MessageBox.Show("요청사항을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RequestWriteEnroll();//요청사항 등록 메소드
            }
        }

        private void RequestWriteEnroll()
        {
            string RequestKind = RequestKind_CmBox.SelectedItem.ToString();
            string Content = RequestContent_txt.Text;
            DateTime WriteDate = DateTime.Now;

            string sql = "INSERT INTO Request_Manage (REQUESTKIND, CONTENT, WRITEDATE, CID, ROOMNUM) VALUES (:REQUESTKIND, :CONTENT, :WRITEDATE, :CID, :ROOMNUM)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("REQUESTKIND", OracleDbType.Varchar2, RequestKind, ParameterDirection.Input),
                new OracleParameter("CONTENT", OracleDbType.Varchar2, Content, ParameterDirection.Input),
                new OracleParameter("WRITEDATE", OracleDbType.Date, WriteDate, ParameterDirection.Input),
                new OracleParameter("CID", OracleDbType.Varchar2, Cid, ParameterDirection.Input),
                new OracleParameter("ROOMNUM", OracleDbType.Int32, RoomNum, ParameterDirection.Input)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
            }
            catch
            {
                MessageBox.Show("요청사항이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("요청사항이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RequestWriteBack_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
