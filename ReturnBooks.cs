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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll= '" + txtenrollmentnumber.Text + "'and book_return_date is NULL";
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count !=0)
            {
            dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtenrollmentnumber.Clear();
        }

        string bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookname.Text = bname;
            txtbookissuedate.Text =bdate;



        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();                                                                                                                                     
                                                                                          
            cmd.CommandText= "update IRBook set book_return_date='"+Bookreturndate.Text+ "' where std_enroll='" + txtenrollmentnumber.Text+"'and id="+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

           MessageBox.Show("Return Successfull.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ReturnBooks_Load(this, null);

        }

        private void txtenrollmentnumber_TextChanged(object sender, EventArgs e)
        {
            if (txtenrollmentnumber.Text=="")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;

            }
        }

        private void btnrefresh1_Click(object sender, EventArgs e)
        {
            txtenrollmentnumber.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }
    }
}
