﻿using AmenityExpress;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace AmenityExpress
{
    public partial class dbTest : Form
    {

        public dbTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MEMBER_CLIENT";
            DataSet dbconnector = DBConnector.DML_QUERY(sql);
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                MessageBox.Show(row[0].ToString().Replace(" ", string.Empty));
                MessageBox.Show(row[1].ToString());
            }



        }

        private void dbTest_Load(object sender, EventArgs e)
        {

        }
    }
}