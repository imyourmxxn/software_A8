using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            radioButton2.Checked = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LogIn_system(textBox1.Text, textBox2.Text);
        }

        public void LogIn_system(string ID, string PW)
        {
            string userID = RemoveHiddenChars(ID);
            string userPassword = RemoveHiddenChars(PW);
            string sql = "SELECT * FROM MEMBER_CLIENT";
            if (radioButton1.Checked) 
            {
                sql = "SELECT * FROM MEMBER_MANAGER";
            }
            DataSet dbconnector = DBConnector.DML_QUERY(sql);


            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                string dbID = RemoveHiddenChars(row[0].ToString());
                string dbPassword = RemoveHiddenChars(row[2].ToString());

                if (dbID == userID)
                {
                    if (row[2].ToString() == PW)
                    {
                        if (radioButton1.Checked) 
                        {
                            ManagerMainUI managerMainUI = new ManagerMainUI(row);
                            this.Visible = false;
                            managerMainUI.Owner = this;
                            managerMainUI.ShowDialog();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            this.Visible = true;
                            return;
                        }
                        else
                        {
                            CustomerMainUI customerMainUI = new CustomerMainUI(row);
                            this.Visible = false;
                            customerMainUI.Owner = this;
                            customerMainUI.ShowDialog();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            this.Visible = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("비밀번호 오류");
                    }
                }
                else { MessageBox.Show("아이디 오류"); }
                
            }
        }

        private string RemoveHiddenChars(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (!char.IsControl(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Trim();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }   
}
