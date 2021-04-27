
namespace Exam
{
    partial class frmstuds
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
            this.lblname = new System.Windows.Forms.Label();
            this.cmbCourseList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.btnstrtExam = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(16, 39);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 31);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Hello";
            // 
            // cmbCourseList
            // 
            this.cmbCourseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCourseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseList.FormattingEnabled = true;
            this.cmbCourseList.Location = new System.Drawing.Point(309, 144);
            this.cmbCourseList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourseList.Name = "cmbCourseList";
            this.cmbCourseList.Size = new System.Drawing.Size(293, 33);
            this.cmbCourseList.TabIndex = 1;
            this.cmbCourseList.Text = "Select your course";
            this.cmbCourseList.SelectedIndexChanged += new System.EventHandler(this.cmbCourseList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Registered Courses:";
            // 
            // txtcourse
            // 
            this.txtcourse.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(23, 262);
            this.txtcourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.ReadOnly = true;
            this.txtcourse.Size = new System.Drawing.Size(187, 34);
            this.txtcourse.TabIndex = 3;
            // 
            // btnstrtExam
            // 
            this.btnstrtExam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnstrtExam.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnstrtExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstrtExam.Location = new System.Drawing.Point(469, 254);
            this.btnstrtExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstrtExam.Name = "btnstrtExam";
            this.btnstrtExam.Size = new System.Drawing.Size(252, 44);
            this.btnstrtExam.TabIndex = 5;
            this.btnstrtExam.Text = "Start Exam";
            this.btnstrtExam.UseVisualStyleBackColor = false;
            this.btnstrtExam.Click += new System.EventHandler(this.btnstrtExam_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.Location = new System.Drawing.Point(729, 254);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(265, 44);
            this.btnShowResult.TabIndex = 6;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // txtDate
            // 
            this.txtDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(228, 262);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(200, 34);
            this.txtDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exam Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your Grade is :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(729, 377);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(46, 17);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "label5";
            // 
            // frmstuds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnstrtExam);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCourseList);
            this.Controls.Add(this.lblname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmstuds";
            this.Text = "frmstuds";
            this.Load += new System.EventHandler(this.frmstuds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmbCourseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Button btnstrtExam;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrade;
    }
}