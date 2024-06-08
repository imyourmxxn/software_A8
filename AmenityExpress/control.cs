using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    class RequestAnswerControl
    {
        public RequestAnswerControl() {}
        public void RequestAnswerEnroll(RequestAnswer_Form UI,Manager manager,Request request, EventHandler e)
        {
            string sql = "UPDATE REQUEST_MANAGE SET STATUE=:STATUE, MID=:MID, ANSWERDATE=:ANSWERDATE, ANSWER=:ANSWER WHERE SNUM = :SNUM";
            OracleParameter[] parameters = new OracleParameter[]
            {
               new OracleParameter("STATUE","답변 완료"),
               new OracleParameter("MID",manager.Id),
                new OracleParameter("ANSWERDATE", request.AnswerDate),
                new OracleParameter("ANSWER", request.Answer),
                new OracleParameter("SNUM",request.SNum)
            };
            try
            {
                DBConnector.DML_NON_QUERY(sql, parameters);
                MessageBox.Show("답변이 등록되었습니다!", "등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Invoke(UI,EventArgs.Empty);
                UI.Close();
            }
            catch
            {
                MessageBox.Show("요청사항에 대한 답변이 등록되지 않았습니다!", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
    }

    class RequestWriteControl
    {
        public RequestWriteControl() { }
        public void RequestWriteEnroll(RequestWrite_Form UI, Reserve reserve, Request request) //요청사항 등록 메소드(DB에 데아터 삽입됨) + 여기 시퀀스 들어가는 부분
        {
                string sql = "INSERT INTO Request_Manage (STATUE, CID, ROOMNUM, WRITEDATE, REQUESTKIND, CONTENT) VALUES (:STATUE, :CID, :ROOMNUM, :WRITEDATE, :REQUESTKIND, :CONTENT)";
                OracleParameter[] parameters = new OracleParameter[]
                {
                new OracleParameter("STATUE",request.Statue),
                new OracleParameter("CID", reserve.ID),
                new OracleParameter("ROOMNUM",reserve.RoomNum),
                new OracleParameter("WRITEDATE", request.WriteDate),
                new OracleParameter("REQUESTKIND", request.RequestKind),
                new OracleParameter("CONTENT", request.Content)
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
                UI.Hide();
            }

        }
    }
}
