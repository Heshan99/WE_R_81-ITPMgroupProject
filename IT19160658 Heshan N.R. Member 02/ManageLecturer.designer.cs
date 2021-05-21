
namespace webapp1
{
    partial class ManageLecturer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.levman = new System.Windows.Forms.ComboBox();
            this.buildman = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cenman = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.depman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.facman = new System.Windows.Forms.ComboBox();
            this.empidman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lecnameman = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rankman = new System.Windows.Forms.TextBox();
            this.lectab = new System.Windows.Forms.DataGridView();
            this.updatelec = new System.Windows.Forms.Button();
            this.deletelec = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectab)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(3, 586);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 34);
            this.panel2.TabIndex = 28;
            // 
            // levman
            // 
            this.levman.FormattingEnabled = true;
            this.levman.Location = new System.Drawing.Point(980, 498);
            this.levman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.levman.Name = "levman";
            this.levman.Size = new System.Drawing.Size(241, 24);
            this.levman.TabIndex = 48;
            // 
            // buildman
            // 
            this.buildman.FormattingEnabled = true;
            this.buildman.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Business Building",
            "Engeneeering Building"});
            this.buildman.Location = new System.Drawing.Point(980, 448);
            this.buildman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildman.Name = "buildman";
            this.buildman.Size = new System.Drawing.Size(241, 24);
            this.buildman.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(762, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(762, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "Building  ";
            // 
            // cenman
            // 
            this.cenman.FormattingEnabled = true;
            this.cenman.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Kandy",
            "Mathara",
            "Kurunagala"});
            this.cenman.Location = new System.Drawing.Point(980, 397);
            this.cenman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cenman.Name = "cenman";
            this.cenman.Size = new System.Drawing.Size(241, 24);
            this.cenman.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(762, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "Center";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // depman
            // 
            this.depman.FormattingEnabled = true;
            this.depman.Items.AddRange(new object[] {
            "Computing ",
            "Business Management",
            "Humanities"});
            this.depman.Location = new System.Drawing.Point(305, 539);
            this.depman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depman.Name = "depman";
            this.depman.Size = new System.Drawing.Size(241, 24);
            this.depman.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(85, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Department     ";
            // 
            // facman
            // 
            this.facman.FormattingEnabled = true;
            this.facman.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences,"});
            this.facman.Location = new System.Drawing.Point(305, 498);
            this.facman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facman.Name = "facman";
            this.facman.Size = new System.Drawing.Size(241, 24);
            this.facman.TabIndex = 40;
            this.facman.SelectedIndexChanged += new System.EventHandler(this.facman_SelectedIndexChanged);
            // 
            // empidman
            // 
            this.empidman.Location = new System.Drawing.Point(305, 451);
            this.empidman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empidman.Name = "empidman";
            this.empidman.Size = new System.Drawing.Size(241, 22);
            this.empidman.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(88, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Employee ID      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(91, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Lecturer Name  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lecnameman
            // 
            this.lecnameman.Location = new System.Drawing.Point(305, 400);
            this.lecnameman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lecnameman.Name = "lecnameman";
            this.lecnameman.Size = new System.Drawing.Size(241, 22);
            this.lecnameman.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(1054, 86);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 30);
            this.button6.TabIndex = 34;
            this.button6.Text = "Manage Sessions";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(846, 86);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 30);
            this.button5.TabIndex = 33;
            this.button5.Text = "Add Sessions";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(643, 86);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 30);
            this.button4.TabIndex = 32;
            this.button4.Text = "Manage Subject";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(445, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 30);
            this.button3.TabIndex = 31;
            this.button3.Text = "Add Subject";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(246, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Manage Lecturer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(47, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Add Lecturer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(85, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Faculty      ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 70);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1253, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(762, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 28);
            this.label9.TabIndex = 50;
            this.label9.Text = "Rank";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // rankman
            // 
            this.rankman.Location = new System.Drawing.Point(980, 540);
            this.rankman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankman.Name = "rankman";
            this.rankman.Size = new System.Drawing.Size(241, 22);
            this.rankman.TabIndex = 51;
            // 
            // lectab
            // 
            this.lectab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectab.Location = new System.Drawing.Point(47, 139);
            this.lectab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lectab.Name = "lectab";
            this.lectab.RowHeadersWidth = 51;
            this.lectab.RowTemplate.Height = 29;
            this.lectab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectab.Size = new System.Drawing.Size(926, 211);
            this.lectab.TabIndex = 52;
            this.lectab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.lectab.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectab_CellContentDoubleClick);
            this.lectab.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lectab_CellMouseDoubleClick);
            // 
            // updatelec
            // 
            this.updatelec.Location = new System.Drawing.Point(1032, 157);
            this.updatelec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatelec.Name = "updatelec";
            this.updatelec.Size = new System.Drawing.Size(215, 42);
            this.updatelec.TabIndex = 53;
            this.updatelec.Text = "UPDATE";
            this.updatelec.UseVisualStyleBackColor = true;
            this.updatelec.Click += new System.EventHandler(this.updatelec_Click);
            // 
            // deletelec
            // 
            this.deletelec.Location = new System.Drawing.Point(1032, 246);
            this.deletelec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletelec.Name = "deletelec";
            this.deletelec.Size = new System.Drawing.Size(215, 42);
            this.deletelec.TabIndex = 54;
            this.deletelec.Text = "DELETE";
            this.deletelec.UseVisualStyleBackColor = true;
            this.deletelec.Click += new System.EventHandler(this.deletelec_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 41);
            this.label11.TabIndex = 55;
            this.label11.Text = "<-";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ManageLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 621);
            this.Controls.Add(this.deletelec);
            this.Controls.Add(this.updatelec);
            this.Controls.Add(this.lectab);
            this.Controls.Add(this.rankman);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.levman);
            this.Controls.Add(this.buildman);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cenman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.depman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.facman);
            this.Controls.Add(this.empidman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lecnameman);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageLecturer";
            this.Text = "ManageLecturer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox levman;
        private System.Windows.Forms.ComboBox buildman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cenman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox depman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox facman;
        private System.Windows.Forms.TextBox empidman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lecnameman;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rankman;
        private System.Windows.Forms.DataGridView lectab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updatelec;
        private System.Windows.Forms.Button deletelec;
        private System.Windows.Forms.Label label11;
    }
}