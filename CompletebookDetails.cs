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

namespace Library_Management_System
{
    public partial class CompletebookDetails : Form
    {
        public CompletebookDetails()
        {
            InitializeComponent();
        }

        private void CompletebookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            cmd.CommandText = "select * from IRBook where book_return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];


        }
    }
}
