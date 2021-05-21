
namespace ITPM
{
    partial class ManageTags
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MngTagDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MngTagName = new System.Windows.Forms.TextBox();
            this.MngCode = new System.Windows.Forms.TextBox();
            this.MngRelatedCode = new System.Windows.Forms.ComboBox();
            this.MngUpdateBtn = new System.Windows.Forms.Button();
            this.MngDeleteBtn = new System.Windows.Forms.Button();
            this.MngClearBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MngTagDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1063, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 45);
            this.panel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(472, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABC Institute";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(541, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Tags";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(816, 83);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Manage Tags";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(288, 83);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Manage Students Groups";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(14, 83);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add Students Groups";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MngTagDataGrid
            // 
            this.MngTagDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MngTagDataGrid.Location = new System.Drawing.Point(194, 155);
            this.MngTagDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngTagDataGrid.Name = "MngTagDataGrid";
            this.MngTagDataGrid.RowHeadersWidth = 51;
            this.MngTagDataGrid.RowTemplate.Height = 25;
            this.MngTagDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MngTagDataGrid.Size = new System.Drawing.Size(674, 157);
            this.MngTagDataGrid.TabIndex = 6;
            this.MngTagDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MngTagDataGrid_CellContentClick);
            this.MngTagDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MngTagDataGrid_CellContentDoubleClick);
            this.MngTagDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MngTagDataGrid_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tag Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(270, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tag Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Related Code";
            // 
            // MngTagName
            // 
            this.MngTagName.Location = new System.Drawing.Point(520, 377);
            this.MngTagName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngTagName.Name = "MngTagName";
            this.MngTagName.Size = new System.Drawing.Size(157, 27);
            this.MngTagName.TabIndex = 10;
            this.MngTagName.TextChanged += new System.EventHandler(this.MngTagName_TextChanged);
            // 
            // MngCode
            // 
            this.MngCode.Location = new System.Drawing.Point(520, 452);
            this.MngCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngCode.Name = "MngCode";
            this.MngCode.Size = new System.Drawing.Size(157, 27);
            this.MngCode.TabIndex = 11;
            // 
            // MngRelatedCode
            // 
            this.MngRelatedCode.FormattingEnabled = true;
            this.MngRelatedCode.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.MngRelatedCode.Location = new System.Drawing.Point(520, 527);
            this.MngRelatedCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngRelatedCode.Name = "MngRelatedCode";
            this.MngRelatedCode.Size = new System.Drawing.Size(157, 28);
            this.MngRelatedCode.TabIndex = 12;
            // 
            // MngUpdateBtn
            // 
            this.MngUpdateBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MngUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MngUpdateBtn.Location = new System.Drawing.Point(757, 568);
            this.MngUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngUpdateBtn.Name = "MngUpdateBtn";
            this.MngUpdateBtn.Size = new System.Drawing.Size(86, 31);
            this.MngUpdateBtn.TabIndex = 14;
            this.MngUpdateBtn.Text = "Update";
            this.MngUpdateBtn.UseVisualStyleBackColor = false;
            this.MngUpdateBtn.Click += new System.EventHandler(this.MngUpdateBtn_Click);
            // 
            // MngDeleteBtn
            // 
            this.MngDeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MngDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MngDeleteBtn.Location = new System.Drawing.Point(880, 568);
            this.MngDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngDeleteBtn.Name = "MngDeleteBtn";
            this.MngDeleteBtn.Size = new System.Drawing.Size(86, 31);
            this.MngDeleteBtn.TabIndex = 15;
            this.MngDeleteBtn.Text = "Delete";
            this.MngDeleteBtn.UseVisualStyleBackColor = false;
            this.MngDeleteBtn.Click += new System.EventHandler(this.MngDeleteBtn_Click);
            // 
            // MngClearBtn
            // 
            this.MngClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MngClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MngClearBtn.Location = new System.Drawing.Point(1002, 568);
            this.MngClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MngClearBtn.Name = "MngClearBtn";
            this.MngClearBtn.Size = new System.Drawing.Size(86, 31);
            this.MngClearBtn.TabIndex = 16;
            this.MngClearBtn.Text = "Clear";
            this.MngClearBtn.UseVisualStyleBackColor = false;
            this.MngClearBtn.Click += new System.EventHandler(this.MngClearBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 39);
            this.panel2.TabIndex = 17;
            // 
            // ManageTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MngClearBtn);
            this.Controls.Add(this.MngDeleteBtn);
            this.Controls.Add(this.MngUpdateBtn);
            this.Controls.Add(this.MngRelatedCode);
            this.Controls.Add(this.MngCode);
            this.Controls.Add(this.MngTagName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MngTagDataGrid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageTags";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MngTagDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView MngTagDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MngTagName;
        private System.Windows.Forms.TextBox MngCode;
        private System.Windows.Forms.ComboBox MngRelatedCode;
        private System.Windows.Forms.Button MngUpdateBtn;
        private System.Windows.Forms.Button MngDeleteBtn;
        private System.Windows.Forms.Button MngClearBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}