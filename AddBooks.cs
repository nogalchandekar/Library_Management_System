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
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class AddBooks : Form
    {

        SqlConnection con;

        public AddBooks()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into AddBook values(@BookID,@BookName,@AuthorName,@No_of_Books,@Year,@Sem,@SubjectName)", con);
                cmd.Parameters.AddWithValue("@BookID",Convert.ToInt32( txtBookId.Text));
                cmd.Parameters.AddWithValue("@BookName",txtBookName.Text);
                cmd.Parameters.AddWithValue("@AuthorName", txtAuthorName.Text);
                cmd.Parameters.AddWithValue("@No_of_Books", Convert.ToInt32(txtNo_ofBooks.Text));
                cmd.Parameters.AddWithValue("@Year",txtYears.Text);
                cmd.Parameters.AddWithValue("@Sem", Convert.ToInt32(txtSemester.Text));
                cmd.Parameters.AddWithValue("@SubjectName",txtSubjectName.Text);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtBookId.Text = "";
                    txtBookName.Text = "";
                    txtAuthorName.Text = "";
                    txtNo_ofBooks.Text = "";
                    txtYears.Text = "";
                    txtSemester.Text = "";
                    txtSubjectName.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went Wrong");
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            txtBookName.Clear();
            txtAuthorName.Clear();
            txtBookName.Clear();
            txtSubjectName.Clear();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will Delete your Unsave Data.", " Are You sure ?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {

            this.Close();

            }
        }
    }
}
