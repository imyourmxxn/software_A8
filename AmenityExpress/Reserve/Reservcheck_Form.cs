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
    public partial class Reservcheck_Form : Form
    {
        Reserve reserve = null;
        public Reservcheck_Form(Reserve reserve)
        {
            InitializeComponent();
            this.reserve = reserve;
            Reserve_set(reserve);
        }

        public void Reserve_set(Reserve reserve)
        { 
            string[] phoneNumberSplit =reserve.Tell.Split('-');
            if (phoneNumberSplit[0] == "010") { Tell_cbb.SelectedIndex = 0; }
            else { Tell_cbb.SelectedIndex=1; }

            KRname_txt.Text = reserve.Name_KR;
            ENGname_txt.Text = reserve.Name_ENG;
            Email_txt.Text = reserve.Email;
            Tell_txt.Text = "-"+phoneNumberSplit[1] + "-" + phoneNumberSplit[2];
            Request_txt.Text = reserve.PRE_REQUEST;

            CKIN_lbl.Text = reserve.CKIN.ToString("MM월 dd일 (ddd)");
            CKOUT_lbl.Text = reserve.CKOUT.ToString("MM월 dd일 (ddd)");
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Reservcheck_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
