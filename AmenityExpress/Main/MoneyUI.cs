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
    public partial class MoneyUI : Form
    {
        public MoneyUI()
        {
            InitializeComponent();
        }

        private void MoneyUI_Load(object sender, EventArgs e)
        {
            year_com.Items.Add("2022");
            year_com.Items.Add("2023");
            month_com.Items.Add("1월");
            month_com.Items.Add("2월");
            month_com.Items.Add("3월");
            week_com.Items.Add("1주");
            week_com.Items.Add("2주");
            week_com.Items.Add("3주");
            week_com.Items.Add("4주");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
                this.Close();  
        }

        private void year_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void month_com_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void week_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
