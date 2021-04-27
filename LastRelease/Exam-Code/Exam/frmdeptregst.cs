using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Exam
{
    public partial class frmdeptregst : Form
    {
        public frmdeptregst()
        {
            InitializeComponent();


        }

        SqlConnection scon;
        SqlCommand scom;
        SqlCommand scom2;
        SqlDataAdapter SA;
        DataTable DA;
        private void frmdeptregst_Load(object sender, EventArgs e)
        {

            scon = new SqlConnection();
            scon.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";
            ///// HELLO

            scon.Open();
            SqlCommand cmd = new SqlCommand("select top(1) Fname +' '+Lname as fullname from Users order by UserId desc", scon);


            var Dr = cmd.ExecuteScalar();


            welcoming.Text = "Hello  " + Dr;

            scon.Close();

            ////////////////////////////
            scom = new SqlCommand();
            scom.Connection = scon;
            scom.CommandType = CommandType.Text;
            scom.CommandText = "select * from Department";
            SA = new SqlDataAdapter(scom);
            DA = new DataTable();
            SA.Fill(DA);
            deptcombo.DataSource = DA;
            deptcombo.DisplayMember = "DDescription";
            deptcombo.ValueMember = "DID";
            scom2 = new SqlCommand();
            scom2.Connection = scon;
            SqlDataAdapter sa2 = new SqlDataAdapter(scom2);
            DataTable da2 = new DataTable();
            scom2.CommandText = "select * from Courses";
            sa2 = new SqlDataAdapter(scom2);
            sa2.Fill(da2);
            coursebox.DataSource = da2;
            coursebox.DisplayMember = "CrsName";
            coursebox.ValueMember = "CrsID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Closed) scon.Open();
            SqlCommand cmdNew = new SqlCommand("select top(1) UserId from Users order by UserId desc", scon);
            int idExm = (int)cmdNew.ExecuteScalar();
            scom.Parameters.Clear();
            scom = new SqlCommand("fillStudentCourse", scon);
            scom.CommandType = CommandType.StoredProcedure;
            scom.Parameters.AddWithValue("@stid", idExm);
            scom.Parameters.AddWithValue("@deptid", (int)deptcombo.SelectedValue);
            scom.Parameters.AddWithValue("@crsId", (int)coursebox.SelectedValue);
            scom.ExecuteScalar();
            scon.Close();
            MessageBox.Show("You have registered in course" + coursebox.SelectedText);
            this.Close();
        }
    }
}
