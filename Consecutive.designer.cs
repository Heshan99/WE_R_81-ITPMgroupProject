
namespace ITPM
{
    partial class Consecutive
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
            this.ConsGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsGrid
            // 
            this.ConsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsGrid.Location = new System.Drawing.Point(66, 132);
            this.ConsGrid.Name = "ConsGrid";
            this.ConsGrid.RowHeadersWidth = 51;
            this.ConsGrid.RowTemplate.Height = 25;
            this.ConsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsGrid.Size = new System.Drawing.Size(950, 218);
            this.ConsGrid.TabIndex = 0;
            this.ConsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsGrid_CellContentClick);
            this.ConsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConsGrid_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-85, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 48);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label8.Location = new System.Drawing.Point(1114, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "x";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(507, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institue";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(846, 69);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 32);
            this.button9.TabIndex = 15;
            this.button9.Text = "Not Available Times";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(571, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(284, 32);
            this.button8.TabIndex = 14;
            this.button8.Text = "Non Overlapping";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(289, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(292, 32);
            this.button7.TabIndex = 13;
            this.button7.Text = "Parellel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(21, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 32);
            this.button6.TabIndex = 12;
            this.button6.Text = "Consecutive";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 31);
            this.panel2.TabIndex = 16;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(252, 397);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 35);
            this.button10.TabIndex = 17;
            this.button10.Text = "Add Session";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(657, 397);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 35);
            this.button11.TabIndex = 18;
            this.button11.Text = "View";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(88, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 41);
            this.label3.TabIndex = 40;
            this.label3.Text = "<-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Consecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1088, 494);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consecutive";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}