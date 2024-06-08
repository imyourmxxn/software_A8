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
        Request request;
        RequestWriteControl writeControl = new RequestWriteControl();
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

        
        private void RequestWriteEnroll_btn_Click(object sender, EventArgs e) //요청사항 작성 버튼
        {
            request = new Request(0,"답변 전",reserve.ID,reserve.RoomNum,DateTime.Now,RequestKind_CmBox.SelectedItem.ToString(),RequestContent_txt.Text,null,null,null);
            bool result = request.CheckRequest();
            if (result)
            {
                writeControl.RequestWriteEnroll(this, reserve, request);
            }
        }

        private void RequestWriteBack_btn_Click(object sender, EventArgs e) //뒤로가기 버튼 클릭하면 상세 예약 조회 화면으로 돌아감
        {
            Close();
        }
    }
}
