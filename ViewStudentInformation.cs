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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchEnrollment.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where Enroll_no Like'"+txtSearchEnrollment.Text+"%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            else
            {

                panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet  DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

         }

        int bid;
        Int64 rowid;

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where Student_ID =" + bid+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtstudentname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtenrollmentno.Text = DS.Tables[0].Rows[0][2].ToString();
            txtdepartment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtstudentsemester.Text = DS.Tables[0].Rows[0][4].ToString();
            txtstudentcontact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtstudentemail.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Student_Name = txtstudentname.Text;
            String Enroll_no = txtenrollmentno.Text;
            String Department = txtdepartment.Text;
            string Semester = txtstudentsemester.Text;
            Int64 Contact = Int64.Parse(txtstudentcontact.Text);
            string Email = txtstudentemail.Text;


            if(MessageBox.Show("Data will updated.Confirm?","Success",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {

            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewStudent set Student_Name='" +Student_Name+ "',Enroll_no='" +Enroll_no+ "',Department='" +Department+ "',Semester='" +Semester+ "',Contact=" + Contact + "',Email=" + Email + "',where Student_ID ="+rowid+"      ";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will Delete.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where Student_ID=" + rowid + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be Lost.","Are you Sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK) 
            {
                this.Close();
            }
           
        }
    }
}
