using AmenityExpress;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

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
            string sql = "SELECT * FROM FAQList";
            DataSet dbconnector = DBConnector.DML_QUERY(sql,null);
            foreach (DataRow row in dbconnector.Tables[0].Rows)
            {
                MessageBox.Show(row[0].ToString());
            }



        }

    }
}