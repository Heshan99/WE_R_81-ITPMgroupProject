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
    public partial class ManageTags : Form
    {
        public ManageTags()
        {
            InitializeComponent();
            populate2();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tdils\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MngStudentsGroups obj = new MngStudentsGroups();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void populate2()
        {
            conec.Open();
            string Query = "select * from tags";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MngTagDataGrid.DataSource = ds.Tables[0];
            conec.Close();

        }




        int key = 0;

        private void MngTagDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            MngTagName.Text = MngTagDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            MngCode.Text = MngTagDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            MngRelatedCode.Text = MngTagDataGrid.SelectedRows[0].Cells[3].Value.ToString();

            if (MngTagName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MngTagDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void MngTagDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        
   

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudentsGroups obj = new AddStudentsGroups();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTags obj = new AddTags();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MngUpdateBtn_Click(object sender, EventArgs e)
        {
            if (MngTagName.Text == "" || MngCode.Text == "" || MngRelatedCode.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update tags set TagName = '" + MngTagName.Text + "',TagCode = '" + MngCode.Text + "',RelatedTag = '" + MngRelatedCode.Text +  "'where Id=" + key + ";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tags Updated successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MngTagName_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void MngDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Tag to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from tags where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Tag Deleted successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MngClearBtn_Click(object sender, EventArgs e)
        {
            MngTagName.Text = "";
            MngCode.Text = "";
            MngRelatedCode.Text = "";
        }

        private void MngTagDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
