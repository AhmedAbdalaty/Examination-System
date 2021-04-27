
namespace Exam
{
    partial class frmExam
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.rdoChoice4 = new System.Windows.Forms.RadioButton();
            this.rdoChoice3 = new System.Windows.Forms.RadioButton();
            this.rdoChoice2 = new System.Windows.Forms.RadioButton();
            this.rdoChoice1 = new System.Windows.Forms.RadioButton();
            this.richTxtQBody = new System.Windows.Forms.RichTextBox();
            this.lblQHeader = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(96, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btn_Next
            // 
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(838, 400);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(89, 32);
            this.btn_Next.TabIndex = 27;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Previous.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(59, 400);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(89, 32);
            this.btn_Previous.TabIndex = 26;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // rdoChoice4
            // 
            this.rdoChoice4.AutoSize = true;
            this.rdoChoice4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdoChoice4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice4.Location = new System.Drawing.Point(59, 335);
            this.rdoChoice4.Name = "rdoChoice4";
            this.rdoChoice4.Size = new System.Drawing.Size(14, 13);
            this.rdoChoice4.TabIndex = 25;
            this.rdoChoice4.TabStop = true;
            this.rdoChoice4.UseVisualStyleBackColor = true;
            // 
            // rdoChoice3
            // 
            this.rdoChoice3.AutoSize = true;
            this.rdoChoice3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdoChoice3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice3.Location = new System.Drawing.Point(59, 296);
            this.rdoChoice3.Name = "rdoChoice3";
            this.rdoChoice3.Size = new System.Drawing.Size(14, 13);
            this.rdoChoice3.TabIndex = 24;
            this.rdoChoice3.TabStop = true;
            this.rdoChoice3.UseVisualStyleBackColor = true;
            // 
            // rdoChoice2
            // 
            this.rdoChoice2.AutoSize = true;
            this.rdoChoice2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdoChoice2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice2.Location = new System.Drawing.Point(59, 257);
            this.rdoChoice2.Name = "rdoChoice2";
            this.rdoChoice2.Size = new System.Drawing.Size(14, 13);
            this.rdoChoice2.TabIndex = 23;
            this.rdoChoice2.TabStop = true;
            this.rdoChoice2.UseVisualStyleBackColor = true;
            // 
            // rdoChoice1
            // 
            this.rdoChoice1.AutoSize = true;
            this.rdoChoice1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdoChoice1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice1.Location = new System.Drawing.Point(59, 218);
            this.rdoChoice1.Name = "rdoChoice1";
            this.rdoChoice1.Size = new System.Drawing.Size(14, 13);
            this.rdoChoice1.TabIndex = 22;
            this.rdoChoice1.TabStop = true;
            this.rdoChoice1.UseVisualStyleBackColor = true;
            // 
            // richTxtQBody
            // 
            this.richTxtQBody.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTxtQBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTxtQBody.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtQBody.Location = new System.Drawing.Point(59, 132);
            this.richTxtQBody.Margin = new System.Windows.Forms.Padding(5);
            this.richTxtQBody.Name = "richTxtQBody";
            this.richTxtQBody.ReadOnly = true;
            this.richTxtQBody.Size = new System.Drawing.Size(854, 52);
            this.richTxtQBody.TabIndex = 21;
            this.richTxtQBody.Text = "";
            // 
            // lblQHeader
            // 
            this.lblQHeader.AutoSize = true;
            this.lblQHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblQHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQHeader.Location = new System.Drawing.Point(62, 96);
            this.lblQHeader.Name = "lblQHeader";
            this.lblQHeader.Size = new System.Drawing.Size(0, 17);
            this.lblQHeader.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(434, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 32);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(128)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(973, 460);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.rdoChoice4);
            this.Controls.Add(this.rdoChoice3);
            this.Controls.Add(this.rdoChoice2);
            this.Controls.Add(this.rdoChoice1);
            this.Controls.Add(this.richTxtQBody);
            this.Controls.Add(this.lblQHeader);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExam";
            this.Text = "frmExam";
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.RadioButton rdoChoice4;
        private System.Windows.Forms.RadioButton rdoChoice3;
        private System.Windows.Forms.RadioButton rdoChoice2;
        private System.Windows.Forms.RadioButton rdoChoice1;
        private System.Windows.Forms.RichTextBox richTxtQBody;
        private System.Windows.Forms.Label lblQHeader;
        private System.Windows.Forms.Button btnSubmit;
    }
}