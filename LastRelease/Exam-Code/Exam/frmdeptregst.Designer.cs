
namespace Exam
{
    partial class frmdeptregst
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
            this.label1 = new System.Windows.Forms.Label();
            this.deptcombo = new System.Windows.Forms.ComboBox();
            this.welcoming = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coursebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department name :";
            // 
            // deptcombo
            // 
            this.deptcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptcombo.FormattingEnabled = true;
            this.deptcombo.Location = new System.Drawing.Point(191, 90);
            this.deptcombo.Name = "deptcombo";
            this.deptcombo.Size = new System.Drawing.Size(216, 28);
            this.deptcombo.TabIndex = 0;
            // 
            // welcoming
            // 
            this.welcoming.AutoSize = true;
            this.welcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcoming.Location = new System.Drawing.Point(12, 50);
            this.welcoming.Name = "welcoming";
            this.welcoming.Size = new System.Drawing.Size(95, 20);
            this.welcoming.TabIndex = 3;
            this.welcoming.Text = "Student ID :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coursebox
            // 
            this.coursebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebox.FormattingEnabled = true;
            this.coursebox.Location = new System.Drawing.Point(191, 121);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(216, 28);
            this.coursebox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Courses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "WELCOME TO REGISTRATION PAGE";
            // 
            // frmdeptregst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coursebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcoming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptcombo);
            this.Name = "frmdeptregst";
            this.Text = "frmdeptregst";
            this.Load += new System.EventHandler(this.frmdeptregst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deptcombo;
        private System.Windows.Forms.Label welcoming;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox coursebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}