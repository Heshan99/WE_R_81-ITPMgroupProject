using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITPM
{
    public partial class AddTags : Form
     
    {
        ManageTags man2 = new ManageTags();
        public AddTags()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tdils\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AddTagsTagName.Text == "" || AddTagsTagCode.Text == "" || AddTagRelatedCode.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tags values('" + AddTagsTagName.Text + "','" + AddTagsTagCode.Text + "','" + AddTagRelatedCode.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tags Added Successfully");
                    con.Close();
                    man2.populate2();
               
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void AddTags_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentsGroups obj = new AddStudentsGroups();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MngStudentsGroups obj = new MngStudentsGroups();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddTagsTagName.Text = "";
            AddTagsTagCode.Text = "";
            AddTagRelatedCode.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestAdding obj = new TestAdding();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageTags obj = new ManageTags();
            obj.Show();
        }

        private void AddTagsTagName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
