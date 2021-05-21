
namespace webapp1
{
    partial class AddLecturers
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lecname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.level = new System.Windows.Forms.ComboBox();
            this.rank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.generatebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 41);
            this.label11.TabIndex = 27;
            this.label11.Text = "<-";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1117, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 27;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(468, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(12, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Lecturer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(202, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Lecturer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(391, 93);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Subject";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(577, 93);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Manage Subject";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(765, 93);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add Sessions";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(949, 93);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "Manage Sessions";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lecname
            // 
            this.lecname.Location = new System.Drawing.Point(234, 157);
            this.lecname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lecname.Name = "lecname";
            this.lecname.Size = new System.Drawing.Size(241, 22);
            this.lecname.TabIndex = 8;
            this.lecname.TextChanged += new System.EventHandler(this.lecname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(66, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lecturer Name  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(66, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee ID      ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // empid
            // 
            this.empid.Location = new System.Drawing.Point(234, 217);
            this.empid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(241, 22);
            this.empid.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(66, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Faculty      ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // faculty
            // 
            this.faculty.FormattingEnabled = true;
            this.faculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences,"});
            this.faculty.Location = new System.Drawing.Point(234, 279);
            this.faculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(241, 24);
            this.faculty.TabIndex = 13;
            this.faculty.SelectedIndexChanged += new System.EventHandler(this.faculty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(66, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Department     ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Computing ",
            "Business Management",
            "Humanities"});
            this.department.Location = new System.Drawing.Point(234, 334);
            this.department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(241, 24);
            this.department.TabIndex = 15;
            this.department.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(671, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Center";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // center
            // 
            this.center.FormattingEnabled = true;
            this.center.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Kandy",
            "Mathara",
            "Kurunagala"});
            this.center.Location = new System.Drawing.Point(831, 157);
            this.center.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(241, 24);
            this.center.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(671, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Building  ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(671, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Level";
            // 
            // building
            // 
            this.building.FormattingEnabled = true;
            this.building.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Business Building",
            "Engeneeering Building"});
            this.building.Location = new System.Drawing.Point(831, 220);
            this.building.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(241, 24);
            this.building.TabIndex = 20;
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.level.Location = new System.Drawing.Point(831, 279);
            this.level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(241, 24);
            this.level.TabIndex = 21;
            this.level.SelectedIndexChanged += new System.EventHandler(this.level_SelectedIndexChanged);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(391, 419);
            this.rank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(399, 22);
            this.rank.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(519, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Generate Rank";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(391, 457);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 41);
            this.clear.TabIndex = 24;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button7_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(685, 457);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 41);
            this.save.TabIndex = 25;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.generatebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.generatebtn.Location = new System.Drawing.Point(910, 418);
            this.generatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(94, 45);
            this.generatebtn.TabIndex = 26;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 34);
            this.panel2.TabIndex = 1;
            // 
            // AddLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.level);
            this.Controls.Add(this.building);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.center);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lecname);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddLecturers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddLecturers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox lecname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox center;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

