﻿
namespace ITPM.Resources
{
    partial class MgtNotAvailbleTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshMgtNtAvaT = new System.Windows.Forms.Button();
            this.backMgtNtAvaT = new System.Windows.Forms.Button();
            this.deleteMgtNtAvaT = new System.Windows.Forms.Button();
            this.mgtNotAvaTime = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgtNotAvaTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Intitute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Not Available Times";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // refreshMgtNtAvaT
            // 
            this.refreshMgtNtAvaT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshMgtNtAvaT.Location = new System.Drawing.Point(133, 427);
            this.refreshMgtNtAvaT.Name = "refreshMgtNtAvaT";
            this.refreshMgtNtAvaT.Size = new System.Drawing.Size(120, 32);
            this.refreshMgtNtAvaT.TabIndex = 21;
            this.refreshMgtNtAvaT.Text = "Refresh";
            this.refreshMgtNtAvaT.UseVisualStyleBackColor = false;
            // 
            // backMgtNtAvaT
            // 
            this.backMgtNtAvaT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backMgtNtAvaT.Location = new System.Drawing.Point(401, 427);
            this.backMgtNtAvaT.Name = "backMgtNtAvaT";
            this.backMgtNtAvaT.Size = new System.Drawing.Size(120, 32);
            this.backMgtNtAvaT.TabIndex = 22;
            this.backMgtNtAvaT.Text = "Back";
            this.backMgtNtAvaT.UseVisualStyleBackColor = false;
            this.backMgtNtAvaT.Click += new System.EventHandler(this.backMgtNtAvaT_Click);
            // 
            // deleteMgtNtAvaT
            // 
            this.deleteMgtNtAvaT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteMgtNtAvaT.Location = new System.Drawing.Point(659, 427);
            this.deleteMgtNtAvaT.Name = "deleteMgtNtAvaT";
            this.deleteMgtNtAvaT.Size = new System.Drawing.Size(120, 32);
            this.deleteMgtNtAvaT.TabIndex = 23;
            this.deleteMgtNtAvaT.Text = "Delete";
            this.deleteMgtNtAvaT.UseVisualStyleBackColor = false;
            this.deleteMgtNtAvaT.Click += new System.EventHandler(this.deleteMgtNtAvaT_Click);
            // 
            // mgtNotAvaTime
            // 
            this.mgtNotAvaTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgtNotAvaTime.Location = new System.Drawing.Point(217, 165);
            this.mgtNotAvaTime.Name = "mgtNotAvaTime";
            this.mgtNotAvaTime.RowTemplate.Height = 25;
            this.mgtNotAvaTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgtNotAvaTime.Size = new System.Drawing.Size(484, 225);
            this.mgtNotAvaTime.TabIndex = 24;
            this.mgtNotAvaTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.mgtNotAvaTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mgtNotAvaTime_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(2, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 37);
            this.panel2.TabIndex = 29;
            // 
            // MgtNotAvailbleTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mgtNotAvaTime);
            this.Controls.Add(this.deleteMgtNtAvaT);
            this.Controls.Add(this.backMgtNtAvaT);
            this.Controls.Add(this.refreshMgtNtAvaT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MgtNotAvailbleTime";
            this.Text = "MgtNotAvailbleTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgtNotAvaTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshMgtNtAvaT;
        private System.Windows.Forms.Button backMgtNtAvaT;
        private System.Windows.Forms.Button deleteMgtNtAvaT;
        private System.Windows.Forms.DataGridView mgtNotAvaTime;
        private System.Windows.Forms.Panel panel2;
    }
}