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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
            SqlConnection con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook";
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];                      


        }
        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
              //  MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel2.Visible = true;
            SqlConnection con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook where BookID="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBookId.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNo_ofBooks.Text = ds.Tables[0].Rows[0][1].ToString();
            txtYears.Text = ds.Tables[0].Rows[0][1].ToString();
            txtSubjectName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtSemester.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBName_TextChanged(object sender, EventArgs e)
        {
            if(txtBName.Text !="")
            {

                SqlConnection con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewBook where BookName LIKE '"+txtBName.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int BookID = (int)Int64.Parse(txtbook_id.Text);
            String BookName = txtBookName.Text;
            String AuthorName = txtAuthorName.Text;
            int no_of_Books = (int)Int64.Parse(txtNo_ofBooks.Text);
            int Year =(int)Int64.Parse(txtYears.Text);
            int Sem =(int)Int64.Parse(txtSemester.Text);
            String SubjectName = txtSubName.Text;


            SqlConnection con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewBook set BookID = '" + BookID + "',BookName = '" + BookName + "',AuthorName = '" + AuthorName + "',no_of_Books='" + no_of_Books + "',Year = '" + Year + "',Sem = '" + Sem + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

       
    }
}
