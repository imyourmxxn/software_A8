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
    public partial class FAQ_Form : Form
    {
        DataSet FAQ_Data;
        Button[] btn_list = new Button[5];
        int FAQ_COUNT = 0, Page_num = 1;
        public FAQ_Form()
        {
            InitializeComponent();
            btn_list[0] = button1;
            btn_list[1] = button2;
            btn_list[2] = button3;
            btn_list[3] = button4;
            btn_list[4] = button5;
        }

        private void FAQ_Form_Load(object sender, EventArgs e)
        {
            FAQ_Data = DBConnector.DML_QUERY("SELECT QUESTION, ANSWER FROM FAQLIST", null);
            FAQ_COUNT = FAQ_Data.Tables[0].Rows.Count;
            if(FAQ_COUNT <= 5)
            {
                btn_home.Visible = false;
                btn_next.Visible = false;
            }
            for(int i = 0; i < 5; i++)
            {
                if (FAQ_COUNT <= i)
                {
                    btn_list[i].Visible = false;
                }
                else
                {
                    btn_list[i].Text = FAQ_Data.Tables[0].Rows[i]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i]["ANSWER"].ToString();
                }
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btn_home_Click(object sender, EventArgs e) //홈버튼
        {
            Page_num = 1;
            for (int i = 0; i < 5; i++)
            {
                btn_list[i].Text = FAQ_Data.Tables[0].Rows[i]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i]["ANSWER"].ToString();
                btn_list[i].Visible = true;
            }
            btn_prev.Visible = false;
            btn_next.Visible = true;
        }

        private void btn_prev_Click(object sender, EventArgs e) //이전 화면 버튼
        {
            Page_num--;
            btn_next.Visible = true;
            if (Page_num == 1)
            {
                btn_prev.Visible = false;
            }
            for(int i = 0; i < 5; i++)
            {
                btn_list[i].Text = FAQ_Data.Tables[0].Rows[i+(Page_num-1)*5]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["ANSWER"].ToString();
                btn_list[i].Visible = true;
            }
        } 

        private void FAQBack_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e) //다음 화면 버튼
        {
            Page_num++;
            btn_prev.Visible = true;
            if (FAQ_COUNT %5 == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    btn_list[i].Text = FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["ANSWER"].ToString();
                    btn_list[i].Visible = true;
                }
                if (Page_num == FAQ_COUNT / 5)
                {
                    btn_next.Visible = false;
                }
            }
            else
            {
                if (Page_num == FAQ_COUNT / 5 + 1)
                {
                    btn_next.Visible = false;
                    for (int i=FAQ_COUNT%5; i < 5; i++)
                    {
                        btn_list[i].Visible = false;
                    }
                    for (int i = 0; i < FAQ_COUNT % 5; i++)
                    {
                        btn_list[i].Text = FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["ANSWER"].ToString();
                        btn_list[i].Visible = true;
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        btn_list[i].Text = FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["QUESTION"].ToString() + "\n" + FAQ_Data.Tables[0].Rows[i + (Page_num - 1) * 5]["ANSWER"].ToString();
                        btn_list[i].Visible = true;
                    }
                }
            }
        }
    }
}
