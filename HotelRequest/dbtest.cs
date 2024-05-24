using HotelRequest;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Oracle_conn_2023
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM FAQList";
            DataSet dbconnector = DBConnector.DML_QUERY(sql);
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                MessageBox.Show(row[0].ToString());
            }
           
            

        }

    }
}