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

        public RequestWrite_Form()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form2_Load);
            //// 콤보박스 선택 변경 이벤트 핸들러 연결
            //this.RequestKind_CmBox.SelectedIndexChanged += new EventHandler(RequestKind_CmBox_SelectedIndexChanged);
            //// 버튼 클릭 이벤트 핸들러 연결
            //this.RequestWriteEnroll_btn.Click += new EventHandler(RequestWriteEnroll_btn_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RequestKind_CmBox.Items.Add("객실 상품 교체 요청");
            RequestKind_CmBox.Items.Add("어매니티 요청");
            RequestKind_CmBox.Items.Add("룸 서비스 요청");
            RequestKind_CmBox.Items.Add("기타사항 요청");

            //this.RequestContent_txt.Text = "기본 텍스트";
        }

        private void RequestKind_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (RequestKind_CmBox.SelectedItem.ToString())
            //{
            //    case "객실 상품 교체 요청":
            //        RequestKind_CmBox.Text = "상품 교체 요청을 입력해주세요.";
            //        break;
            //    case "어매니티 요청":
            //        RequestKind_CmBox.Text = "[어매니티 리스트]: 칫솔, 치약, 샴푸, 린스, 클렌징폼, 스킨, 로션, 수건";
            //        break;
            //    case "룸 서비스 요청":
            //        RequestKind_CmBox.Text = "[식사부]\n전복솥밥, 가지만두, 동파육 덮밥, 봉골레파스타\n[디저트]\n초콜릿무스, 치즈케이크, 누텔라 크로플, 과일산도\n[음료부]\n콜라, 사이다, 맥주, 와인";
            //        break;
            //    case "기타사항 요청":
            //        RequestKind_CmBox.Text = "기타 요청사항을 입력해주세요.";
            //        break;
            //    default:
            //        RequestKind_CmBox.Text = string.Empty;
            //        break;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void RequestWriteEnroll_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RequestKind_CmBox.Text)) //gpt코드
            {
                MessageBox.Show("요청사항 종류를 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RequestContent_txt.Clear(); //내용 적었는데 요청사항 종류 안 골랐을 때
            }
            else if (string.IsNullOrWhiteSpace(RequestContent_txt.Text)) //gpt코드
            {
                MessageBox.Show("요청사항을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RequestContent_txt.Clear();

            }
            else
            {
                // 등록 로직을 여기에 추가하세요.
                MessageBox.Show("요청사항이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
