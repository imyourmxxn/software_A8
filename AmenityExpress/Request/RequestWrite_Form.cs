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
        Reserve reserve;
        public RequestWrite_Form(Reserve reserve)
        {
            InitializeComponent();
            this.reserve = reserve;
        }

        private void Form2_Load(object sender, EventArgs e) //요청사항 종류 콤보박스 4가지 내용
        {
            RequestKind_CmBox.Items.Add("객실 상품 교체 요청");
            RequestKind_CmBox.Items.Add("어매니티 요청");
            RequestKind_CmBox.Items.Add("룸 서비스 요청");
            RequestKind_CmBox.Items.Add("기타사항 요청");
        }

        private void RequestKind_CmBox_SelectedIndexChanged(object sender, EventArgs e) //요청사항 종류 콤보박스 4개 목록 중 하나를 선택할 시에,
                                                                                        //요청사항 종류에 해당하는 안내 메세지 박스 출력
        {
            string selectedItem = RequestKind_CmBox.SelectedItem.ToString(); 

            switch (selectedItem)
            {
                case "객실 상품 교체 요청":
                    MessageBox.Show("교체를 원하는 상품을 입력해주세요!", "객실 상품 교체 요청", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "어매니티 요청":
                    MessageBox.Show("[신청 가능 어매니티]: 칫솔, 치약, 샴푸, 린스, 로션, 스킨, 폼클렌징, 일회용면도기", "어매니티 요청", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "룸 서비스 요청":
                    MessageBox.Show("[식사부]: 전복솥밥/ 동파육덮밥/ 스테이크/ 돈코츠라멘 \n [디저트류] 초콜릿무스/ 오미자푸딩/ 망고빙수 \n [드링크] 콜라/ 사이다/ 소주/ 와인", "룸 서비스 요청", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "기타사항 요청":
                    MessageBox.Show("기타 요청사항을 입력해주세요!", "기타사항 요청", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void CheckRequest()//요청사항 작성 완료했는 지 체크하는 메소드
        {
            if (string.IsNullOrWhiteSpace(RequestKind_CmBox.Text)) //요청사항 종류를 선택하지 않고 등록버튼 클릭시
            {
                MessageBox.Show("요청사항 종류를 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(RequestContent_txt.Text)) //요청사항 내용을 입력하지 않고 등록버튼 클릭시
            {
                MessageBox.Show("요청사항을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RequestInfoEnroll();//요청사항 등록 메소드 사용하여 받은 요청사항을 DB에 삽입함
            }
        }
        private void RequestWriteEnroll_btn_Click(object sender, EventArgs e) //요청사항 작성 버튼
        {
            CheckRequest();
        }

        private void RequestInfoEnroll() //요청사항 등록 메소드(DB에 데아터 삽입됨) + 여기 시퀀스 들어가는 부분
        {
            string RequestKind = RequestKind_CmBox.SelectedItem.ToString();
            string Content = RequestContent_txt.Text;
            DateTime WriteDate = DateTime.Now;

            string sql = "INSERT INTO Request_Manage (STATUE, CID, ROOMNUM, WRITEDATE, REQUESTKIND, CONTENT) VALUES (:STATUE, :CID, :ROOMNUM, :WRITEDATE, :REQUESTKIND, :CONTENT)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("STATUE","답변 전"),
                new OracleParameter("CID", reserve.ID),
                new OracleParameter("ROOMNUM",reserve.RoomNum),
                new OracleParameter("WRITEDATE", WriteDate),
                new OracleParameter("REQUESTKIND", RequestKind),
                new OracleParameter("CONTENT", Content)
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
            DialogResult enrollok = MessageBox.Show("요청사항이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (enrollok == DialogResult.OK) //메세지박스의 ok버튼 클릭시 요청사항 목록 폼으로 넘어감
            {
                // 새로운 폼을 생성하고 표시
                RequestList_Form requestlist_form = new RequestList_Form();
                requestlist_form.Show();

                // 기존 폼을 숨김
                this.Hide();
            }

        }

        private void RequestWriteBack_btn_Click(object sender, EventArgs e) //뒤로가기 버튼 클릭하면 상세 예약 조회 화면으로 돌아감
        {
            Close();
        }
    }
}
