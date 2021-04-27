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
    public partial class frmExam : Form
    {
        #region attributes
        public int crsid { get; set; }
        public int stid { get; set; }
        public String examDate { get; set; }
        int examID;
        int answerID;
        SqlConnection sqlCN;
        BindingSource examBindingSource;
        BindingSource QChoiceBindingSource;
        SqlCommand sqlCmd;
        SqlCommand sqlCmdExamid;
        SqlCommand cmdChoices;
        SqlCommand cmdInsertAnswers;
        SqlDataAdapter DA;
        SqlDataAdapter DAChoices;
        SqlDataAdapter DAStudAnswers;
        SqlDataAdapter DAGetModelAnswers;
        DataTable DT;
        DataTable DTChoices;
        DataTable DTStudAnswers;
        DataTable DTGetModelAnswers;
        List<string> StudentAnswer;
        List<string> FinalStudentAnswer;
        List<int> FinalQuestionsId;

        List<string> ModelAnswers;
        //List<string> StudentAnswers;
        int tos = 0;
        #endregion

        public frmExam()
        {
            InitializeComponent();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            StudentAnswer = new List<string>(15);
            FinalStudentAnswer = new List<string>(15);
            FinalQuestionsId = new List<int>(15);
            sqlCN = new SqlConnection("Data Source=.;Initial Catalog=Examination System SD_41;Integrated Security=true");

            ///////////////////
            sqlCmdExamid = new SqlCommand("getExamId", sqlCN);
            if (sqlCN?.State == ConnectionState.Closed) sqlCN.Open();
            sqlCmdExamid.CommandType = CommandType.StoredProcedure;
            sqlCmdExamid.Parameters.Add("@crsid", crsid);
            sqlCmdExamid.Parameters.Add("@stid", stid);
            sqlCmdExamid.Parameters.Add("@examdate", examDate);
            examID = (int)sqlCmdExamid?.ExecuteScalar();
            sqlCN.Close();
            ///////////////////
            ///
            sqlCmd = new SqlCommand("getexamdetail", sqlCN);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ExamID", examID);////************this should not be constant*************
            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();
            DA.Fill(DT);
            examBindingSource = new BindingSource(DT, "");
            lblQHeader.DataBindings.Add("Text", examBindingSource, "QHeader");
            richTxtQBody.DataBindings.Add("Text", examBindingSource, "QBody");

            FinalQuestionsId = DataTableToQuestionId(DT).Distinct().ToList();

            DataRowView current = (DataRowView)examBindingSource.Current;
            cmdChoices = new SqlCommand("GetQChoices", sqlCN);
            cmdChoices.CommandType = CommandType.StoredProcedure;
            cmdChoices.Parameters.AddWithValue("@QID", current["QID"]);

            DTChoices = new DataTable();
            DAChoices = new SqlDataAdapter(cmdChoices);
            DAChoices.Fill(DTChoices);
            QChoiceBindingSource = new BindingSource(DTChoices, "");
            rdoChoice1.DataBindings.Add("Text", QChoiceBindingSource[0], "QChoice");
            rdoChoice2.DataBindings.Add("Text", QChoiceBindingSource[1], "QChoice");
            if (QChoiceBindingSource.Count > 2) rdoChoice3.DataBindings.Add("Text", QChoiceBindingSource[2], "QChoice");
            if (QChoiceBindingSource.Count > 3) rdoChoice4.DataBindings.Add("Text", QChoiceBindingSource[3], "QChoice");
            clearRadioButtons();
            btnSubmit.Enabled = false;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            ///this returns examBindingSource.Count=15 question and will 
            //that the questions would move after each other correctley
            if (tos == 13)
            {
                btnSubmit.Enabled = true;
                btn_Next.Enabled = false;
            }
            if ((StudentAnswer.Count == tos) && (StudentAnswer.Count < 15))
            {
                if (rdoChoice1.Checked == true) StudentAnswer.Add(rdoChoice1.Text + StudentAnswer.Count);
                else if (rdoChoice2.Checked == true) StudentAnswer.Add(rdoChoice2.Text + StudentAnswer.Count);
                else if (rdoChoice3.Checked == true) StudentAnswer.Add(rdoChoice3.Text + StudentAnswer.Count);
                else if (rdoChoice4.Checked == true) StudentAnswer.Add(rdoChoice4.Text + StudentAnswer.Count);
            }
            tos++;
            if (StudentAnswer.Count > (tos - 1))
            {
                if (rdoChoice1.Checked == true) StudentAnswer[tos - 1] = rdoChoice1.Text + (tos - 1);
                else if (rdoChoice2.Checked == true) StudentAnswer[tos - 1] = rdoChoice2.Text + (tos - 1);
                else if (rdoChoice3.Checked == true) StudentAnswer[tos - 1] = rdoChoice3.Text + (tos - 1);
                else if (rdoChoice4.Checked == true) StudentAnswer[tos - 1] = rdoChoice4.Text + (tos - 1);
            }
            examBindingSource.Filter = "Qchoice LIKE 'a)%'";
            examBindingSource.MoveNext();
            bindingQuestions();
            if (StudentAnswer.Count > tos - 1) checkPreviousAnswers();
            //if (tos > 15)
            //{
            //    tos = 15;
            //}
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            ///this returns examBindingSource.Count=15 question and will 
            //that the questions would move after each other correctley
            if (tos == 14)
            {
                btnSubmit.Enabled = false;
                btn_Next.Enabled = true;
            }
            tos--;
            if (tos < 0) tos = 0;
            examBindingSource.Filter = "Qchoice LIKE 'a)%'";
            examBindingSource.MovePrevious();
            bindingQuestions();
            checkPreviousAnswers();
        }
        private void bindingQuestions()
        {
            clearBindingParameters();
            DataRowView current = (DataRowView)examBindingSource.Current;
            rdoChoice1.Text = ""; rdoChoice2.Text = ""; rdoChoice3.Text = ""; rdoChoice4.Text = "";
            cmdChoices.Parameters.AddWithValue("@QID", current["QID"]);
            DTChoices = new DataTable();
            DAChoices = new SqlDataAdapter(cmdChoices);
            DAChoices.Fill(DTChoices);
            QChoiceBindingSource = new BindingSource(DTChoices, "");
            rdoChoice1.DataBindings.Add("Text", QChoiceBindingSource[0], "QChoice");
            rdoChoice2.DataBindings.Add("Text", QChoiceBindingSource[1], "QChoice");
            if (QChoiceBindingSource.Count > 2) rdoChoice3.DataBindings.Add("Text", QChoiceBindingSource[2], "QChoice");
            if (QChoiceBindingSource.Count > 3) rdoChoice4.DataBindings.Add("Text", QChoiceBindingSource[3], "QChoice");
            clearRadioButtons();
        }
        private void clearBindingParameters()
        {
            cmdChoices.Parameters.Clear();
            DTChoices.Clear();
            rdoChoice1.DataBindings.Clear();
            rdoChoice2.DataBindings.Clear();
            rdoChoice3.DataBindings.Clear();
            rdoChoice4.DataBindings.Clear();
        }
        private void clearRadioButtons()
        {
            rdoChoice1.Checked = false;
            rdoChoice2.Checked = false;
            rdoChoice3.Checked = false;
            rdoChoice4.Checked = false;
            if (QChoiceBindingSource.Count == 4)
            {
                rdoChoice3.Visible = true;
                rdoChoice4.Visible = true;
            }
            if (QChoiceBindingSource.Count == 2)
            {
                rdoChoice3.Visible = false;
                rdoChoice4.Visible = false;
            }
        }
        private void checkPreviousAnswers()
        {
            for (int i = 0; i < StudentAnswer.Count; i++)
            {
                //if (QChoiceBindingSource.Count == 4)
                //{
                if (rdoChoice1.Text + tos == StudentAnswer[i]) rdoChoice1.Checked = true;
                else if (rdoChoice2.Text + tos == StudentAnswer[i]) rdoChoice2.Checked = true;
                else if (rdoChoice3.Text + tos == StudentAnswer[i]) rdoChoice3.Checked = true;
                else if (rdoChoice4.Text + tos == StudentAnswer[i]) rdoChoice4.Checked = true;
                //}
            }
            //if ((QChoiceBindingSource.Count == 2) && (StudentAnswer?.Count > tos + 1))
            //{
            //    if (rdoChoice1.Text == StudentAnswer[tos]) rdoChoice1.Checked = true;
            //    else if (rdoChoice2.Text == StudentAnswer[tos]) rdoChoice2.Checked = true;
            //}
        }
        private void InsertExamAnswers()
        {
            for (int i = 0; i < StudentAnswer?.Count; i++)
            {
                FinalStudentAnswer.Add(StudentAnswer[i].Substring(0, 1));
                cmdInsertAnswers = new SqlCommand("InsertStudAnswer", sqlCN);
                cmdInsertAnswers.Parameters.Clear();
                cmdInsertAnswers.CommandType = CommandType.StoredProcedure;
                cmdInsertAnswers.Parameters.AddWithValue("@stId", stid);
                cmdInsertAnswers.Parameters.AddWithValue("@crsId", crsid);
                cmdInsertAnswers.Parameters.AddWithValue("@examID", examID);
                cmdInsertAnswers.Parameters.AddWithValue("@Qid", FinalQuestionsId[i]);
                cmdInsertAnswers.Parameters.AddWithValue("@studentAns", FinalStudentAnswer[i]);
                DAStudAnswers = new SqlDataAdapter(cmdInsertAnswers);
                DTStudAnswers = new DataTable();
                DTStudAnswers.Clear();
                DAStudAnswers.Fill(DTStudAnswers);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdoChoice1.Checked == true) StudentAnswer.Add(rdoChoice1.Text);
            else if (rdoChoice2.Checked == true) StudentAnswer.Add(rdoChoice2.Text);
            else if (rdoChoice3.Checked == true) StudentAnswer.Add(rdoChoice3.Text);
            else if (rdoChoice4.Checked == true) StudentAnswer.Add(rdoChoice4.Text);

            if ((DialogResult)MessageBox.Show("Confirm leaving the exam", "MojoCRM", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                InsertExamAnswers();
                 CalculateGrades();
                if(grade<36)
                {
                   RequestReExamination();
                }
                this.Close();
            }
        }

        #region correction
        int grade;
        private void CalculateGrades()
        {
            GetModelAnswers();
            getAnswerid();
            grade = 0;
            for (int i = 0; i < FinalStudentAnswer?.Count; i++)
            {
                if (FinalStudentAnswer[i] == ModelAnswers[i]) grade += 4;
            }
            sqlCmd.Parameters.Clear();
            if (sqlCN.State == ConnectionState.Closed) sqlCN.Open();
            sqlCmd = new SqlCommand("UpdateStudGrade", sqlCN);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@AnsId", answerID);
            sqlCmd.Parameters.AddWithValue("@StuGrade", grade);
            sqlCmd.Parameters.AddWithValue("@stId", stid);
            sqlCmd.Parameters.AddWithValue("@crsId", crsid);
            sqlCmd.ExecuteNonQuery();
            sqlCN.Close();
        }
        private void GetModelAnswers()
        {
            sqlCmd.Parameters.Clear();
            sqlCmd = new SqlCommand("getAllModelAnswers", sqlCN);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@examid", examID);
            DAGetModelAnswers = new SqlDataAdapter(sqlCmd);
            DTGetModelAnswers = new DataTable();
            DAGetModelAnswers.Fill(DTGetModelAnswers);
            ModelAnswers = DataTableToQuestionId(DTGetModelAnswers, "ModelAnswer");
        }
        private int getAnswerid()
        {
            sqlCmd.Parameters.Clear();
            sqlCmd = new SqlCommand("getAnswerid", sqlCN);
            if (sqlCN.State == ConnectionState.Closed) sqlCN.Open();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@examid", examID);
            sqlCmd.Parameters.AddWithValue("@stid", stid);
            sqlCmd.Parameters.AddWithValue("@crsid", crsid);
            answerID = (int)sqlCmd.ExecuteScalar();
            sqlCN.Close();
            return answerID;
        }
        #endregion
        #region Mapping Functions
        internal static List<int> DataTableToQuestionId(DataTable Dt)
        {
            List<int> QuestionIdLst = new List<int>();
            try
            {

                if (Dt?.Rows?.Count > 0)
                {
                    foreach (DataRow Dr in Dt.Rows)
                    {
                        QuestionIdLst.Add(DataRowToQuestionId(Dr));
                    }
                }
            }
            catch
            {

            }
            return QuestionIdLst;
        }

        internal static int DataRowToQuestionId(DataRow Dr)
        {
            int Id = 0;
            try
            {
                Id = Dr.Field<int>("QID");
            }
            catch
            {
            }
            return Id;
        }

        #endregion
        #region Mapping2 Functions
        internal static List<string> DataTableToQuestionId(DataTable Dt, string Param)
        {
            List<string> QuestionIdLst = new List<string>();
            try
            {

                if (Dt?.Rows?.Count > 0)
                {
                    foreach (DataRow Dr in Dt.Rows)
                    {
                        QuestionIdLst.Add(DataRowToQuestionId(Dr, Param));
                    }
                }
            }
            catch
            {

            }
            return QuestionIdLst;
        }

        internal static string DataRowToQuestionId(DataRow Dr, string Param)
        {
            string Id = "";
            try
            {
                Id = Dr.Field<string>(Param);
            }
            catch
            {
            }
            return Id;
        }

        #endregion

        void RequestReExamination()
        {
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "REquestReExamination";
            sqlCmd.Parameters.AddWithValue("@Stid", stid);
            sqlCmd.Parameters.AddWithValue("@CourseId", crsid);
            sqlCmd.Parameters.AddWithValue("@ExamDate", DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd"));
            if (sqlCN?.State == ConnectionState.Closed) sqlCN.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCN.Close();

        }

    }
}
