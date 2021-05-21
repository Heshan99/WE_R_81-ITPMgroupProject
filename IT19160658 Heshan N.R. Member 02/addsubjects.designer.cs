
namespace webapp1
{
    partial class addsubjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ofyear = new System.Windows.Forms.ComboBox();
            this.ofsem = new System.Windows.Forms.ComboBox();
            this.subname = new System.Windows.Forms.TextBox();
            this.subcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lechours = new System.Windows.Forms.NumericUpDown();
            this.tutehours = new System.Windows.Forms.NumericUpDown();
            this.labhours = new System.Windows.Forms.NumericUpDown();
            this.evalhours = new System.Windows.Forms.NumericUpDown();
            this.clearbb = new System.Windows.Forms.Button();
            this.savebb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lechours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutehours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labhours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evalhours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 88);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1301, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 27;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(538, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 43);
            this.panel2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(26, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "Add Lecturer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(247, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Manage Lecturer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(1092, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 38);
            this.button6.TabIndex = 35;
            this.button6.Text = "Manage Sessions";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(886, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 38);
            this.button5.TabIndex = 34;
            this.button5.Text = "Add Sessions";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(675, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 38);
            this.button4.TabIndex = 33;
            this.button4.Text = "Manage Subject";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(452, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 38);
            this.button3.TabIndex = 32;
            this.button3.Text = "Add Subject";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Offered Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Offered Semester";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Subject Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Subject Code";
            // 
            // ofyear
            // 
            this.ofyear.FormattingEnabled = true;
            this.ofyear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.ofyear.Location = new System.Drawing.Point(235, 233);
            this.ofyear.Name = "ofyear";
            this.ofyear.Size = new System.Drawing.Size(425, 28);
            this.ofyear.TabIndex = 40;
            this.ofyear.SelectedIndexChanged += new System.EventHandler(this.ofyear_SelectedIndexChanged);
            // 
            // ofsem
            // 
            this.ofsem.FormattingEnabled = true;
            this.ofsem.Items.AddRange(new object[] {
            "Semester One",
            "Semeste Two"});
            this.ofsem.Location = new System.Drawing.Point(235, 307);
            this.ofsem.Name = "ofsem";
            this.ofsem.Size = new System.Drawing.Size(425, 28);
            this.ofsem.TabIndex = 41;
            // 
            // subname
            // 
            this.subname.Location = new System.Drawing.Point(235, 379);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(425, 27);
            this.subname.TabIndex = 42;
            // 
            // subcode
            // 
            this.subcode.Location = new System.Drawing.Point(235, 461);
            this.subcode.Name = "subcode";
            this.subcode.Size = new System.Drawing.Size(425, 27);
            this.subcode.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(770, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Numbers Of Lecture Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(770, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Number Of Tutorial Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(770, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Number Of Lab Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(770, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Number Of Evaluation Hours";
            // 
            // lechours
            // 
            this.lechours.Location = new System.Drawing.Point(1156, 236);
            this.lechours.Name = "lechours";
            this.lechours.Size = new System.Drawing.Size(150, 27);
            this.lechours.TabIndex = 49;
            // 
            // tutehours
            // 
            this.tutehours.Location = new System.Drawing.Point(1156, 312);
            this.tutehours.Name = "tutehours";
            this.tutehours.Size = new System.Drawing.Size(150, 27);
            this.tutehours.TabIndex = 50;
            // 
            // labhours
            // 
            this.labhours.Location = new System.Drawing.Point(1156, 384);
            this.labhours.Name = "labhours";
            this.labhours.Size = new System.Drawing.Size(150, 27);
            this.labhours.TabIndex = 51;
            // 
            // evalhours
            // 
            this.evalhours.Location = new System.Drawing.Point(1156, 462);
            this.evalhours.Name = "evalhours";
            this.evalhours.Size = new System.Drawing.Size(150, 27);
            this.evalhours.TabIndex = 52;
            // 
            // clearbb
            // 
            this.clearbb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearbb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbb.Location = new System.Drawing.Point(846, 554);
            this.clearbb.Name = "clearbb";
            this.clearbb.Size = new System.Drawing.Size(182, 50);
            this.clearbb.TabIndex = 53;
            this.clearbb.Text = "Clear";
            this.clearbb.UseVisualStyleBackColor = false;
            this.clearbb.Click += new System.EventHandler(this.clearbb_Click);
            // 
            // savebb
            // 
            this.savebb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebb.Location = new System.Drawing.Point(1124, 554);
            this.savebb.Name = "savebb";
            this.savebb.Size = new System.Drawing.Size(182, 50);
            this.savebb.TabIndex = 54;
            this.savebb.Text = "Save";
            this.savebb.UseVisualStyleBackColor = false;
            this.savebb.Click += new System.EventHandler(this.savebb_Click);
            // 
            // addsubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 679);
            this.Controls.Add(this.savebb);
            this.Controls.Add(this.clearbb);
            this.Controls.Add(this.evalhours);
            this.Controls.Add(this.labhours);
            this.Controls.Add(this.tutehours);
            this.Controls.Add(this.lechours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subcode);
            this.Controls.Add(this.subname);
            this.Controls.Add(this.ofsem);
            this.Controls.Add(this.ofyear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addsubjects";
            this.Text = "addsubjects";
            this.Load += new System.EventHandler(this.addsubjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lechours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutehours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labhours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evalhours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ofyear;
        private System.Windows.Forms.ComboBox ofsem;
        private System.Windows.Forms.TextBox subname;
        private System.Windows.Forms.TextBox subcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown lechours;
        private System.Windows.Forms.NumericUpDown tutehours;
        private System.Windows.Forms.NumericUpDown labhours;
        private System.Windows.Forms.NumericUpDown evalhours;
        private System.Windows.Forms.Button clearbb;
        private System.Windows.Forms.Button savebb;
    }
}