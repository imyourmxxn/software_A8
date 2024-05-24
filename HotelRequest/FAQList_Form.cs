using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HotelRequest
{
    public partial class FAQList_Form : Form
    {
        string connectionString = "User Id=<admin>;Password=<1562>;DataSource=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=gyeongmin2022.kro.kr)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)))";
        OracleConnection conn;
        OracleCommand cmd;
        public FAQList_Form()
        {
            InitializeComponent();
        }

        private void FAQEnroll_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(connectionString);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            DataSet ds = new DataSet();
            string SQL = "SELECT * FROM FAQList";
            OracleDataAdapter ad = new OracleDataAdapter();
            ad.SelectCommand = new OracleCommand(SQL, conn);
            ad.Fill(ds, "FAQList");

            //FAQ_listview.Data source = ds.Tables[0];
            conn.Close();


        }

        private void FAQFix_btn_Click(object sender, EventArgs e)
        {
            // 수정 버튼 클릭 로직
        }

        private void FAQDel_btn_Click(object sender, EventArgs e)
        {
            // 삭제 버튼 클릭 로직
        }
    }
}

