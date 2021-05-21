
namespace ITPM
{
    partial class AddStudentsGroups
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddStudentAcademicYearSemester = new System.Windows.Forms.TextBox();
            this.AddStudentProgramm = new System.Windows.Forms.ComboBox();
            this.AddStudentGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.AddStudentSubGroupNumber = new System.Windows.Forms.NumericUpDown();
            this.AddStudentGroupID = new System.Windows.Forms.TextBox();
            this.AddStudentSubGroupID = new System.Windows.Forms.TextBox();
            this.AddStudentSaveBtn = new System.Windows.Forms.Button();
            this.AddStudentGenarateIDBtn = new System.Windows.Forms.Button();
            this.AddStudentClearBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentGroupNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentSubGroupNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(880, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "x";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(363, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button9.Location = new System.Drawing.Point(3, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Add Students Groups";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(186, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Manage Students Groups";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(366, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Tags";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(547, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Manage Tags";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(727, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Session And Not Available Time";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Academic Year Semester";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(186, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Programm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Group Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(186, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sub Group Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(186, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Group ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(186, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sub Group ID";
            // 
            // AddStudentAcademicYearSemester
            // 
            this.AddStudentAcademicYearSemester.Location = new System.Drawing.Point(520, 160);
            this.AddStudentAcademicYearSemester.Name = "AddStudentAcademicYearSemester";
            this.AddStudentAcademicYearSemester.Size = new System.Drawing.Size(148, 23);
            this.AddStudentAcademicYearSemester.TabIndex = 22;
            this.AddStudentAcademicYearSemester.TextChanged += new System.EventHandler(this.AddStudentAcademicYearSemester_TextChanged);
            // 
            // AddStudentProgramm
            // 
            this.AddStudentProgramm.FormattingEnabled = true;
            this.AddStudentProgramm.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "DS",
            "ISE",
            "CSNE"});
            this.AddStudentProgramm.Location = new System.Drawing.Point(520, 214);
            this.AddStudentProgramm.Name = "AddStudentProgramm";
            this.AddStudentProgramm.Size = new System.Drawing.Size(148, 23);
            this.AddStudentProgramm.TabIndex = 23;
            // 
            // AddStudentGroupNumber
            // 
            this.AddStudentGroupNumber.Location = new System.Drawing.Point(521, 267);
            this.AddStudentGroupNumber.Name = "AddStudentGroupNumber";
            this.AddStudentGroupNumber.Size = new System.Drawing.Size(147, 23);
            this.AddStudentGroupNumber.TabIndex = 24;
            this.AddStudentGroupNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // AddStudentSubGroupNumber
            // 
            this.AddStudentSubGroupNumber.Location = new System.Drawing.Point(521, 325);
            this.AddStudentSubGroupNumber.Name = "AddStudentSubGroupNumber";
            this.AddStudentSubGroupNumber.Size = new System.Drawing.Size(147, 23);
            this.AddStudentSubGroupNumber.TabIndex = 25;
            // 
            // AddStudentGroupID
            // 
            this.AddStudentGroupID.Location = new System.Drawing.Point(521, 383);
            this.AddStudentGroupID.Name = "AddStudentGroupID";
            this.AddStudentGroupID.Size = new System.Drawing.Size(148, 23);
            this.AddStudentGroupID.TabIndex = 26;
            // 
            // AddStudentSubGroupID
            // 
            this.AddStudentSubGroupID.Location = new System.Drawing.Point(521, 440);
            this.AddStudentSubGroupID.Name = "AddStudentSubGroupID";
            this.AddStudentSubGroupID.Size = new System.Drawing.Size(148, 23);
            this.AddStudentSubGroupID.TabIndex = 27;
            // 
            // AddStudentSaveBtn
            // 
            this.AddStudentSaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStudentSaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddStudentSaveBtn.Location = new System.Drawing.Point(684, 491);
            this.AddStudentSaveBtn.Name = "AddStudentSaveBtn";
            this.AddStudentSaveBtn.Size = new System.Drawing.Size(88, 35);
            this.AddStudentSaveBtn.TabIndex = 28;
            this.AddStudentSaveBtn.Text = "Save";
            this.AddStudentSaveBtn.UseVisualStyleBackColor = false;
            this.AddStudentSaveBtn.Click += new System.EventHandler(this.AddStudentSaveBtn_Click);
            // 
            // AddStudentGenarateIDBtn
            // 
            this.AddStudentGenarateIDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddStudentGenarateIDBtn.Location = new System.Drawing.Point(773, 376);
            this.AddStudentGenarateIDBtn.Name = "AddStudentGenarateIDBtn";
            this.AddStudentGenarateIDBtn.Size = new System.Drawing.Size(88, 35);
            this.AddStudentGenarateIDBtn.TabIndex = 31;
            this.AddStudentGenarateIDBtn.Text = "Genarate ID";
            this.AddStudentGenarateIDBtn.UseVisualStyleBackColor = false;
            this.AddStudentGenarateIDBtn.Click += new System.EventHandler(this.AddStudentGenarateIDBtn_Click);
            // 
            // AddStudentClearBtn
            // 
            this.AddStudentClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStudentClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddStudentClearBtn.Location = new System.Drawing.Point(804, 491);
            this.AddStudentClearBtn.Name = "AddStudentClearBtn";
            this.AddStudentClearBtn.Size = new System.Drawing.Size(88, 35);
            this.AddStudentClearBtn.TabIndex = 32;
            this.AddStudentClearBtn.Text = "Clear";
            this.AddStudentClearBtn.UseVisualStyleBackColor = false;
            this.AddStudentClearBtn.Click += new System.EventHandler(this.AddStudentClearBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(-3, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 24);
            this.panel2.TabIndex = 1;
            // 
            // AddStudentsGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddStudentClearBtn);
            this.Controls.Add(this.AddStudentGenarateIDBtn);
            this.Controls.Add(this.AddStudentSaveBtn);
            this.Controls.Add(this.AddStudentSubGroupID);
            this.Controls.Add(this.AddStudentGroupID);
            this.Controls.Add(this.AddStudentSubGroupNumber);
            this.Controls.Add(this.AddStudentGroupNumber);
            this.Controls.Add(this.AddStudentProgramm);
            this.Controls.Add(this.AddStudentAcademicYearSemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentsGroups";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentGroupNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentSubGroupNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddStudentAcademicYearSemester;
        private System.Windows.Forms.ComboBox AddStudentProgramm;
        private System.Windows.Forms.NumericUpDown AddStudentGroupNumber;
        private System.Windows.Forms.NumericUpDown AddStudentSubGroupNumber;
        private System.Windows.Forms.TextBox AddStudentGroupID;
        private System.Windows.Forms.TextBox AddStudentSubGroupID;
        private System.Windows.Forms.Button AddStudentSaveBtn;
        private System.Windows.Forms.Button AddStudentGenarateIDBtn;
        private System.Windows.Forms.Button AddStudentClearBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}

