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
    public partial class RoomSearch_Form : Form
    {
        Client client = null; Reserve reserve = null;
        public RoomSearch_Form(Client client, Reserve reserve)
        {
            InitializeComponent();
            this.client = client; this.reserve = reserve;
        }

        private void RoomSearch_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Reserv_Form reserve_form = new Reserv_Form(client, reserve);
            reserve_form.Owner = this;
            reserve_form.ShowDialog();
            this.Visible = true;
        }
    }
}
