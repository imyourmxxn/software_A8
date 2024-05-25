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
        public Pay_Form(Reserve reserv, Client client)
        {
            InitializeComponent();

            label9.Text = reserv.CKIN + "~" + reserv.CKOUT;
            label10.Text = reserv.RoomNum.ToString();
            textBox1.Text = client.Point.ToString();
        }

        private void Pay_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
