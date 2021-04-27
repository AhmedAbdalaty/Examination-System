
namespace Exam
{
    partial class frmInstructor
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
            this.headerIns = new System.Windows.Forms.Button();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.Label();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.comboTopics = new System.Windows.Forms.ComboBox();
            this.insTopics = new System.Windows.Forms.Label();
            this.txtInsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCourses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMCQ = new System.Windows.Forms.ComboBox();
            this.comboTANDF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // headerIns
            // 
            this.headerIns.BackColor = System.Drawing.Color.White;
            this.headerIns.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headerIns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.headerIns.FlatAppearance.BorderSize = 0;
            this.headerIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerIns.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerIns.ForeColor = System.Drawing.Color.Black;
            this.headerIns.Location = new System.Drawing.Point(163, 15);
            this.headerIns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerIns.Name = "headerIns";
            this.headerIns.Size = new System.Drawing.Size(980, 87);
            this.headerIns.TabIndex = 0;
            this.headerIns.Text = "Welcome to the exam preparation page";
            this.headerIns.UseVisualStyleBackColor = false;
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGenerateExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateExam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateExam.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnGenerateExam.ForeColor = System.Drawing.Color.White;
            this.btnGenerateExam.Location = new System.Drawing.Point(407, 576);
            this.btnGenerateExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(639, 47);
            this.btnGenerateExam.TabIndex = 4;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = false;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // txtDept
            // 
            this.txtDept.AutoSize = true;
            this.txtDept.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDept.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDept.ForeColor = System.Drawing.Color.Black;
            this.txtDept.Location = new System.Drawing.Point(157, 171);
            this.txtDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(232, 30);
            this.txtDept.TabIndex = 0;
            this.txtDept.Text = "Your department is ";
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackColor = System.Drawing.Color.Black;
            this.pictureBoxclose.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxclose.ImageLocation = "../../images/x.png";
            this.pictureBoxclose.Location = new System.Drawing.Point(1281, 15);
            this.pictureBoxclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(21, 20);
            this.pictureBoxclose.TabIndex = 3;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // comboTopics
            // 
            this.comboTopics.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboTopics.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTopics.FormattingEnabled = true;
            this.comboTopics.Location = new System.Drawing.Point(407, 229);
            this.comboTopics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTopics.Name = "comboTopics";
            this.comboTopics.Size = new System.Drawing.Size(639, 32);
            this.comboTopics.TabIndex = 5;
            this.comboTopics.Text = "Choose the exam topic";
            this.comboTopics.SelectionChangeCommitted += new System.EventHandler(this.comboTopics_SelectionChangeCommitted);
            // 
            // insTopics
            // 
            this.insTopics.AutoSize = true;
            this.insTopics.Font = new System.Drawing.Font("Tahoma", 15F);
            this.insTopics.ForeColor = System.Drawing.Color.Black;
            this.insTopics.Location = new System.Drawing.Point(157, 236);
            this.insTopics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insTopics.Name = "insTopics";
            this.insTopics.Size = new System.Drawing.Size(94, 30);
            this.insTopics.TabIndex = 6;
            this.insTopics.Text = "Topics:";
            // 
            // txtInsName
            // 
            this.txtInsName.AutoSize = true;
            this.txtInsName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtInsName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtInsName.ForeColor = System.Drawing.Color.Black;
            this.txtInsName.Location = new System.Drawing.Point(157, 106);
            this.txtInsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInsName.Name = "txtInsName";
            this.txtInsName.Size = new System.Drawing.Size(113, 30);
            this.txtInsName.TabIndex = 7;
            this.txtInsName.Text = "Hello Mr.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Courses:";
            // 
            // comboCourses
            // 
            this.comboCourses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCourses.FormattingEnabled = true;
            this.comboCourses.Location = new System.Drawing.Point(407, 298);
            this.comboCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCourses.Name = "comboCourses";
            this.comboCourses.Size = new System.Drawing.Size(639, 32);
            this.comboCourses.TabIndex = 9;
            this.comboCourses.Text = "Choose the exam course";
            this.comboCourses.SelectedIndexChanged += new System.EventHandler(this.comboCourses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "No.of MCQ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(157, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "No.of T and F Q : ";
            // 
            // comboMCQ
            // 
            this.comboMCQ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMCQ.FormattingEnabled = true;
            this.comboMCQ.Location = new System.Drawing.Point(407, 367);
            this.comboMCQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMCQ.Name = "comboMCQ";
            this.comboMCQ.Size = new System.Drawing.Size(639, 32);
            this.comboMCQ.TabIndex = 12;
            this.comboMCQ.Text = "Choose the number of MCQ qestions";
            this.comboMCQ.SelectedIndexChanged += new System.EventHandler(this.comboMCQ_SelectedIndexChanged);
            // 
            // comboTANDF
            // 
            this.comboTANDF.Enabled = false;
            this.comboTANDF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTANDF.FormattingEnabled = true;
            this.comboTANDF.Location = new System.Drawing.Point(407, 436);
            this.comboTANDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTANDF.Name = "comboTANDF";
            this.comboTANDF.Size = new System.Drawing.Size(639, 32);
            this.comboTANDF.TabIndex = 13;
            this.comboTANDF.Text = "Choose the number of true and false qestions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(157, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Exam Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 505);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(639, 32);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(763, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Generate Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxclose);
            this.Controls.Add(this.comboTANDF);
            this.Controls.Add(this.comboMCQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCourses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsName);
            this.Controls.Add(this.insTopics);
            this.Controls.Add(this.comboTopics);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.headerIns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInstructor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button headerIns;
        private System.Windows.Forms.Label txtDept;
        private System.Windows.Forms.Button btnGenerateExam;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.ComboBox comboTopics;
        private System.Windows.Forms.Label insTopics;
        private System.Windows.Forms.Label txtInsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMCQ;
        private System.Windows.Forms.ComboBox comboTANDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}
