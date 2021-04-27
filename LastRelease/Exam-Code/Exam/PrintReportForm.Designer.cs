
namespace Exam
{
    partial class PrintReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtStuedntId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInstId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTopicId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtexamId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtStudentIdForEXam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtExamStudentId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(62, 98);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(176, 33);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Preview Student Info";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(12, 44);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(99, 17);
            this.lblDeptId.TabIndex = 1;
            this.lblDeptId.Text = "Department ID";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(174, 41);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(85, 22);
            this.txtDeptId.TabIndex = 2;
            // 
            // txtStuedntId
            // 
            this.txtStuedntId.Location = new System.Drawing.Point(174, 165);
            this.txtStuedntId.Name = "txtStuedntId";
            this.txtStuedntId.Size = new System.Drawing.Size(85, 22);
            this.txtStuedntId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Preview Student Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInstId
            // 
            this.txtInstId.Location = new System.Drawing.Point(599, 41);
            this.txtInstId.Name = "txtInstId";
            this.txtInstId.Size = new System.Drawing.Size(85, 22);
            this.txtInstId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instructor ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Preview Instructor Course  Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTopicId
            // 
            this.txtTopicId.Location = new System.Drawing.Point(599, 165);
            this.txtTopicId.Name = "txtTopicId";
            this.txtTopicId.Size = new System.Drawing.Size(85, 22);
            this.txtTopicId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Topic ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Preview Topics Courses";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtexamId
            // 
            this.txtexamId.Location = new System.Drawing.Point(174, 317);
            this.txtexamId.Name = "txtexamId";
            this.txtexamId.Size = new System.Drawing.Size(85, 22);
            this.txtexamId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Exam Id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Preview Exam Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtStudentIdForEXam
            // 
            this.txtStudentIdForEXam.Location = new System.Drawing.Point(599, 298);
            this.txtStudentIdForEXam.Name = "txtStudentIdForEXam";
            this.txtStudentIdForEXam.Size = new System.Drawing.Size(85, 22);
            this.txtStudentIdForEXam.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Student Id";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(440, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 33);
            this.button5.TabIndex = 15;
            this.button5.Text = "Preview Student Exam Q and A";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtExamStudentId
            // 
            this.txtExamStudentId.Location = new System.Drawing.Point(599, 348);
            this.txtExamStudentId.Name = "txtExamStudentId";
            this.txtExamStudentId.Size = new System.Drawing.Size(85, 22);
            this.txtExamStudentId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Exam ID";
            // 
            // PrintReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExamStudentId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentIdForEXam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtexamId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTopicId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtInstId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStuedntId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.btnPrint);
            this.Name = "PrintReportForm";
            this.Text = "PrintReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtStuedntId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInstId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTopicId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtexamId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtStudentIdForEXam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtExamStudentId;
        private System.Windows.Forms.Label label6;
    }
}