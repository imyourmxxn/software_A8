﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AmenityExpress
{
    public partial class Reservlist_Form : Form
    {
        ReserveSearch_system control= new ReserveSearch_system();
        Client client;
        bool check;
        public Reservlist_Form(Client client, bool check)
        {
            InitializeComponent();
            this.client = client;
            this.check = check;
            reservelist_view(check);
            Room_cbb.SelectedIndex = 0;
        }


        public void reservelist_view(bool check) 
        {
            control.reservelist(Reservelist_listView, client, check);
        }

        private void Reservlist_Form_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            control.search_sys(CKOUT_dtp, CKIN_dtp, Room_cbb, Reservelist_listView, Search_txt, client, check);
        }

        private void Room_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reservelist_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (Reservelist_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Reservelist_listView.SelectedItems[0];
                Reserve reserve = control.selected_Load(selectedItem);

                Room room = control.search_Room(reserve);

                if (check)
                {
                    Reservcheck_Form form = new Reservcheck_Form(null, reserve, room);
                    this.Visible = false;
                    form.Owner = this;
                    form.ShowDialog();
                }
                else
                {
                    Reservcheck_Form form = new Reservcheck_Form(client, reserve, room);
                    this.Visible = false;
                    form.Owner = this;
                    form.ShowDialog();
                }


                this.Visible = true;
                Reservelist_listView.Items.Clear();
                reservelist_view(check);
            }
            else
            {
                MessageBox.Show("항목을 선택하세요.");
            }
        }

        private void Room_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
