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
    public partial class ManagerMainUI : Form
    {
        public ManagerMainUI(DataRow row)
        {
            InitializeComponent();
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void money_btn_Click(object sender, EventArgs e)
        {
            MoneyUI moneyUI = new MoneyUI();
            moneyUI.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void reserv_btn_Click(object sender, EventArgs e)
        {
            Reserv_Form reserv_form = new Reserv_Form();
            reserv_form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            RoomSearchM_Form roomSearchM_Form = new RoomSearchM_Form();
            roomSearchM_Form.Show();
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            RequestManage_Form requestManage_Form = new RequestManage_Form();
            requestManage_Form.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
        }
    }
}