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
    public partial class IssueBooks : Form
    {
        private object comboBoxBooks;

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select BookName from NewBook",con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while(Sdr.Read())
            {
                
            }
            Sdr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEnrollment.Text  != "")
            {
                String Enroll_no = txtEnrollment.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewStudent where Enroll_no='" + Enroll_no + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //-------------------------------------------------------------------------------------------
                //code to count how many book has been issued on this enrollment number
                cmd.CommandText = "Select count (std_enroll) from IRBook std_enroll='" + Enroll_no + "'and book_return_date in null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                //------------------------------------------------------------------------------






                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtdepartment.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtsemester.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtcontact.Text = DS.Tables[0].Rows[0][4].ToString();

                }
                else
                {
                    txtname.Clear();
                    txtdepartment.Clear();
                    txtsemester.Clear();
                    txtcontact.Clear();
                    MessageBox.Show("Invalid enrollment No","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnissuedate_Click(object sender, EventArgs e)
        {
            if(txtname.Text != "")
            {
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
