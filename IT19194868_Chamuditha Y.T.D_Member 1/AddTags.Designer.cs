﻿
namespace ITPM
{
    partial class AddTags
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTagSaveBtn = new System.Windows.Forms.Button();
            this.AddTagClearBtn = new System.Windows.Forms.Button();
            this.AddTagsTagName = new System.Windows.Forms.TextBox();
            this.AddTagsTagCode = new System.Windows.Forms.TextBox();
            this.AddTagRelatedCode = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(889, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 28);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Institute";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(737, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Session And Not Available Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(12, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Students Groups";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(193, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Manage Students Groups";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(375, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Tags";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(556, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "Manage Tags";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tag Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(247, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Related Tag";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(247, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tag Code";
            // 
            // AddTagSaveBtn
            // 
            this.AddTagSaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTagSaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddTagSaveBtn.Location = new System.Drawing.Point(530, 391);
            this.AddTagSaveBtn.Name = "AddTagSaveBtn";
            this.AddTagSaveBtn.Size = new System.Drawing.Size(79, 28);
            this.AddTagSaveBtn.TabIndex = 9;
            this.AddTagSaveBtn.Text = "Save";
            this.AddTagSaveBtn.UseVisualStyleBackColor = false;
            this.AddTagSaveBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddTagClearBtn
            // 
            this.AddTagClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTagClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddTagClearBtn.Location = new System.Drawing.Point(693, 391);
            this.AddTagClearBtn.Name = "AddTagClearBtn";
            this.AddTagClearBtn.Size = new System.Drawing.Size(79, 28);
            this.AddTagClearBtn.TabIndex = 10;
            this.AddTagClearBtn.Text = "Clear";
            this.AddTagClearBtn.UseVisualStyleBackColor = false;
            this.AddTagClearBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // AddTagsTagName
            // 
            this.AddTagsTagName.Location = new System.Drawing.Point(556, 173);
            this.AddTagsTagName.Name = "AddTagsTagName";
            this.AddTagsTagName.Size = new System.Drawing.Size(155, 23);
            this.AddTagsTagName.TabIndex = 11;
            this.AddTagsTagName.TextChanged += new System.EventHandler(this.AddTagsTagName_TextChanged);
            // 
            // AddTagsTagCode
            // 
            this.AddTagsTagCode.Location = new System.Drawing.Point(556, 239);
            this.AddTagsTagCode.Name = "AddTagsTagCode";
            this.AddTagsTagCode.Size = new System.Drawing.Size(155, 23);
            this.AddTagsTagCode.TabIndex = 12;
            // 
            // AddTagRelatedCode
            // 
            this.AddTagRelatedCode.FormattingEnabled = true;
            this.AddTagRelatedCode.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.AddTagRelatedCode.Location = new System.Drawing.Point(556, 312);
            this.AddTagRelatedCode.Name = "AddTagRelatedCode";
            this.AddTagRelatedCode.Size = new System.Drawing.Size(155, 23);
            this.AddTagRelatedCode.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(-4, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 28);
            this.panel3.TabIndex = 14;
            // 
            // AddTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AddTagRelatedCode);
            this.Controls.Add(this.AddTagsTagCode);
            this.Controls.Add(this.AddTagsTagName);
            this.Controls.Add(this.AddTagClearBtn);
            this.Controls.Add(this.AddTagSaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTags";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddTags_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTagSaveBtn;
        private System.Windows.Forms.Button AddTagClearBtn;
        private System.Windows.Forms.TextBox AddTagsTagName;
        private System.Windows.Forms.TextBox AddTagsTagCode;
        private System.Windows.Forms.ComboBox AddTagRelatedCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}