using AmenityExpress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmenityExpress
{
    public partial class Pay_Form : Form
    {
        public Pay_Form(Client client, Reserve reserve)
        {
            InitializeComponent();

            label9.Text = reserve.CKIN + "~" + reserve.CKOUT;
            label10.Text = reserve.RoomNum.ToString();
            textBox1.Text = client.Point.ToString();
        }

        private void Pay_Form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
