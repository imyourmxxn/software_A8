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
        Manager manager;
        public ManagerMainUI(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            label1.Text = manager.Name + "님 환영합니다!";
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void money_btn_Click(object sender, EventArgs e)
        {
            MoneyUI moneyUI = new MoneyUI();
            moneyUI.Show();
        }

       

        private void reserv_btn_Click(object sender, EventArgs e)
        {
            Reservlist_Form reserv_form = new Reservlist_Form(null,true);
            reserv_form.Show();
        }

        
        private void room_btn_Click(object sender, EventArgs e)
        {
            ManagerRoomCheck managerRoomCheck = new ManagerRoomCheck();
            managerRoomCheck.Show();
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            RequestManage_Form requestManage_Form = new RequestManage_Form(manager);
            requestManage_Form.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            ClientInformMangement clientInformManagetmentUI = new ClientInformMangement();
            clientInformManagetmentUI.Show();
        }

        

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn login = new LogIn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
