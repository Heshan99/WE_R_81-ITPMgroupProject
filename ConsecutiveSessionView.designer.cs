
namespace ITPM
{
    partial class ConsecutiveSessionView
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConsecutiveSessionViewGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsecutiveSessionViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-80, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 47);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(928, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 30);
            this.panel4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(426, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "ABC Institute";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1016, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 30);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(-1, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 49);
            this.panel3.TabIndex = 2;
            // 
            // ConsecutiveSessionViewGrid
            // 
            this.ConsecutiveSessionViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsecutiveSessionViewGrid.Location = new System.Drawing.Point(83, 96);
            this.ConsecutiveSessionViewGrid.Name = "ConsecutiveSessionViewGrid";
            this.ConsecutiveSessionViewGrid.RowHeadersWidth = 51;
            this.ConsecutiveSessionViewGrid.RowTemplate.Height = 25;
            this.ConsecutiveSessionViewGrid.Size = new System.Drawing.Size(762, 266);
            this.ConsecutiveSessionViewGrid.TabIndex = 3;
            this.ConsecutiveSessionViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(110, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Consecutive Sessions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(81, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 41);
            this.label4.TabIndex = 40;
            this.label4.Text = "<-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ConsecutiveSessionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConsecutiveSessionViewGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsecutiveSessionView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConsecutiveSessionView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsecutiveSessionViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ConsecutiveSessionViewGrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}