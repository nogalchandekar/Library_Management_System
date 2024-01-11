using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddStudent: Form
    {
        SqlConnection con;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
            this.Close();
            } 
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtstudentName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            //String name=txtstudentName.Text;
          //  string enroll = txtEnrollment.Text;
          //  String dep = txtDepartment.Text;
           // string sem = txtSemester.Text;
           // Int64 mobile=Int64.Parse(txtContact.Text);
           // String email = txtEmail.Text;

            //SqlConnection con = new SqlConnection();
            //con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
           // SqlCommand cmd = new SqlCommand();
           // cmd.Connection = con;

           // con.Open();
            //cmd.CommandText= "insert into NewStudent(Student_Name,Student_Name,Department,Semester,Contact,Email) values ('"+name+"','"+enroll+ ",'"+dep+"','"+sem+ ",'"+mobile+"','"+email+"')";
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Data Saved!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            try
            {
                con = new SqlConnection("data source=DESKTOP-OJFFLEF\\SQLEXPRESS;database= Login_data;User Id=sa;password=123456");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into NewStudent values(@Student_Name,@Enroll_no,@Department,@Semester,@Contact,@Email)",con);
                cmd.Parameters.AddWithValue("@Student_Name",(txtstudentName.Text));
                cmd.Parameters.AddWithValue("@Enroll_no", txtEnrollment.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@Semester", txtSemester);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email",txtEmail);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                    txtstudentName.Text = "";
                    txtEnrollment.Text = "";
                    txtDepartment.Text = "";
                    txtSemester.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
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


        }
    }
}
