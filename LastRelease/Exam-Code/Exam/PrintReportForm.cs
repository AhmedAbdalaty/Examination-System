using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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

namespace Exam
{
    public partial class PrintReportForm : Form
    {
        ReportDocument RD;
        ReportViewer RV;
        SqlConnection conn;
        SqlCommand cmd;
        public PrintReportForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport1.rpt");
            RD.SetParameterValue("@departmentnumber",Convert.ToInt32(txtDeptId.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport2.rpt");
            RD.SetParameterValue("@studentID", Convert.ToInt32(txtStuedntId.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport3.rpt");
            RD.SetParameterValue("@insID", Convert.ToInt32(txtInstId.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport4.rpt");
            RD.SetParameterValue("@TopicID", Convert.ToInt32(txtTopicId.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport5.rpt");
            RD.SetParameterValue("@ExamID", Convert.ToInt32(txtexamId.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RD = new ReportDocument();
            RV = new ReportViewer();
            RD.Load("../../CrystalReport6.rpt");
            RD.SetParameterValue("@examID", Convert.ToInt32(txtExamStudentId.Text));
            RD.SetParameterValue("@studentID", Convert.ToInt32(txtStudentIdForEXam.Text));
            RV.crystalReportViewer1.ReportSource = RD;
            RV.crystalReportViewer1.Refresh();
            RV.ShowDialog();
        }
    }
}
