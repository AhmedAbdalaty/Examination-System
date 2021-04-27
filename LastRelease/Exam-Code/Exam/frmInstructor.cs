using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam
{
    public partial class frmInstructor : Form
    {
        SqlConnection sqlcn;
        SqlCommand cmd;
        public string mail;
        public frmInstructor()
        {
            InitializeComponent();
        }

        private void frmInstructor_Load(object sender, EventArgs e)
        {
            {
                sqlcn = new SqlConnection();
                sqlcn.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";
                int insId = 1;
                cmd = new SqlCommand("getUserId", sqlcn);
                if (sqlcn.State == ConnectionState.Closed) sqlcn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", mail);
                insId = (int)cmd.ExecuteScalar();
                cmd = new SqlCommand("select DName from Department d inner join Instructor " +
                                     "i on i.DeptID = d.DID where i.InsID =" + insId, sqlcn);
                string dept = cmd.ExecuteScalar().ToString();
                txtDept.Text = "Your department is " + dept;
                cmd = new SqlCommand("select Fname +' '+Lname as fullname from Users where UserId=" + insId, sqlcn);
                string Name = cmd.ExecuteScalar().ToString();
                txtInsName.Text = "Hello Mr. " + Name; ;
                cmd = new SqlCommand("select TopicName from Topic T inner join Courses c on " +
                                       "c.TopicID=T.TopicID inner join InstructorCourse ic " +
                                       "on ic.CrsID=c.CrsID where ic.InsID=" + insId, sqlcn);
                SqlDataReader Dr = cmd.ExecuteReader();
                comboTopics.Items.Clear();
                while (Dr.Read())
                {
                    comboTopics.Items.Add(Dr["TopicName"]);
                }
                sqlcn.Close();
            }
        }
        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            sqlcn = new SqlConnection();
            sqlcn.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";
            cmd = new SqlCommand("InsGenerateExam", sqlcn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MCQnum", int.Parse(comboMCQ.Text));
            cmd.Parameters.Add("@TFnum", int.Parse(comboTANDF.Text));
            cmd.Parameters.Add("@CourseName", comboCourses.Text);
            cmd.Parameters.Add("@ExamDate", dateTimePicker1.Value.Year.ToString() + '-' + dateTimePicker1.Value.Month.ToString() + '-' + dateTimePicker1.Value.Day.ToString());
            SqlDataAdapter Da = new SqlDataAdapter(cmd); ;
            DataSet DS = new DataSet(); 
            Da.Fill(DS);
            // SqlCommandBuilder SCB = new SqlCommandBuilder(Da);
            MessageBox.Show("Data Inserted");
            this.Close();
        }

        private void comboTopics_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sqlcn = new SqlConnection();
            var topic = comboTopics.SelectedItem.ToString();
            sqlcn.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";
            if (sqlcn.State == ConnectionState.Closed) sqlcn.Open();
            cmd = new SqlCommand("getCourses", sqlcn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@topicName", comboTopics.SelectedItem.ToString());
            cmd.Parameters.Add("@email", mail);
            SqlDataReader Dr = cmd.ExecuteReader();
            comboCourses.Items.Clear();
            while (Dr.Read())
            {
                comboCourses.Items.Add(Dr["CrsName"]);
            }
            sqlcn.Close();
        }

        private void comboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMCQ.Items.Clear();
            for (int i = 0; i <= 15; i++)
            {
                comboMCQ.Items.Add(i);
            }
        }
        private void comboMCQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTANDF.Items.Clear();
            comboTANDF.Items.Add(15 - int.Parse(comboMCQ.SelectedItem.ToString()));
            comboTANDF.SelectedItem = 15 - int.Parse(comboMCQ.SelectedItem.ToString());
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintReportForm pr = new PrintReportForm();
            this.Hide();
            pr.ShowDialog();
            this.Show();
        }
    }
}
