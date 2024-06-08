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
        Manager manager;
        Client client;
        
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
            DataSet dbconnector = DBConnector.DML_QUERY(sql,null);


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
                            manager = new Manager(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                            ManagerMainUI managerMainUI = new ManagerMainUI(manager);
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
                            client = new Client(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), int.Parse(row[7].ToString()));
                            CustomerMainUI customerMainUI = new CustomerMainUI(client);
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
                        MessageBox.Show("비밀번호 오류");  return;
                    }
                }
            }
            MessageBox.Show("아이디 오류");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
