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
    public partial class frmstuds : Form
    {
        public frmstuds()
        {
            InitializeComponent();
        }
        #region attributes
        public string mail;
        int STID;
        int selectedcid;
        frmExam frmexam = new frmExam();
        SqlConnection sqlcn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;
        SqlCommand cmd5;
        SqlDataAdapter DA;
        SqlDataAdapter DA2;
        DataTable DT;
        DataTable DTcourses;
        #endregion

        private void frmstuds_Load(object sender, EventArgs e)
        {
            btnShowResult.Enabled = false;
            btnstrtExam.Enabled = false;
            this.cmbCourseList.FormattingEnabled = false;
            lblGrade.Visible = false;
            label4.Visible = false;

            sqlcn = new SqlConnection();
            sqlcn.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";

            cmd = new SqlCommand("getUserId", sqlcn);
            if (sqlcn?.State == ConnectionState.Closed) sqlcn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", mail);
            STID = (int)cmd.ExecuteScalar();

            cmd2 = new SqlCommand("getStudentName", sqlcn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@id", STID);
            string studname = cmd2.ExecuteScalar().ToString();
            lblname.Text = "Hello  " + studname;
            sqlcn.Close();

            cmd3 = new SqlCommand("getStudentCourses", sqlcn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("@stdID", STID);
            DA2 = new SqlDataAdapter(cmd3);
            DTcourses = new DataTable();
            DA2.Fill(DTcourses);
            cmbCourseList.DataSource = DTcourses;
            cmbCourseList.DisplayMember = "CourseName";
            cmbCourseList.ValueMember = "CourseID";
        }


        private void btnstrtExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexam.stid = STID;
            frmexam.crsid = selectedcid;
            frmexam.examDate = txtDate.Text;
            frmexam.ShowDialog();
            this.Close();
        }

        private void cmbCourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowResult.Enabled = false;
            btnstrtExam.Enabled = false;
            DataRowView drv = (DataRowView)cmbCourseList.SelectedItem;
            selectedcid = (int)drv.Row.ItemArray[1];

            txtcourse.Text = drv.Row.ItemArray[0].ToString();
            cmd4 = new SqlCommand("getCourseExamDateandid", sqlcn);
            cmd4.CommandType = CommandType.StoredProcedure;

            cmd4.Parameters.AddWithValue("@stID", STID);
            cmd4.Parameters.AddWithValue("@CID", selectedcid);

            DA = new SqlDataAdapter(cmd4);
            DT = new DataTable();
            DA.Fill(DT);
            txtDate.Text = String.Empty;
            if (DT.Rows.Count != 0)
            {
                var datarow = DT.Rows[0];
                txtDate.Text = ((DateTime)datarow["ExamDate"]).ToString(("yyyy-MM-dd"));
            }
            if ((txtDate.Text != String.Empty) || (txtDate.Text == DateTime.Now.ToString("yyyy-MM-dd")))
            {
                btnstrtExam.Enabled = true;
            }
            cmd5 = new SqlCommand("getStudentGradeIfFound", sqlcn);
            if (sqlcn?.State == ConnectionState.Closed) sqlcn.Open();
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd5.Parameters.Add("@crsid", selectedcid);
            cmd5.Parameters.Add("@stid", STID);
            cmd5.Parameters.Add("@examdate", txtDate.Text);
            string ReturnGrade = cmd5?.ExecuteScalar()?.ToString() ?? "";
            sqlcn.Close();
            if (ReturnGrade != "")
            {
                btnShowResult.Enabled = true;
                btnstrtExam.Enabled = false;
            }
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "GetStudentExamCourseGrade";
            cmd.Parameters.AddWithValue("@studentID", STID);
            cmd.Parameters.AddWithValue("@crsid", selectedcid);
            if (sqlcn?.State == ConnectionState.Closed) sqlcn.Open();
            lblGrade.Text=cmd.ExecuteScalar().ToString();
            lblGrade.Visible = true;
            label4.Visible = true;
            sqlcn.Close();
            
        }
    }
}
