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
    public partial class MngStudentsGroups : Form
    {
        public MngStudentsGroups()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddStudentsGroups obj = new AddStudentsGroups();
            obj.Show();
            this.Hide();
        }

        private void MngClear_Click(object sender, EventArgs e)
        {
            MngAcaademicSemester.Text = "";
            MngProgramm.Text = "";
            MngGroupNumber.Text = "";
            MngSubGroupNumber.Text = "";
            MngGroupID.Text = "";
            MngSubGroupID.Text = "";





        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTags obj = new AddTags();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populate()
        {
            conec.Open();
            string Query = "select * from addstudent";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AddStudentDataGrid.DataSource = ds.Tables[0];
            conec.Close();

        }

        int key = 0;

        private void AddStudentDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MngAcaademicSemester.Text = AddStudentDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            MngProgramm.Text = AddStudentDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            MngGroupNumber.Text = AddStudentDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            MngSubGroupNumber.Text = AddStudentDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            MngGroupID.Text = AddStudentDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            MngSubGroupID.Text = AddStudentDataGrid.SelectedRows[0].Cells[6].Value.ToString();


            if (MngAcaademicSemester.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AddStudentDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void MngDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Student Group to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from addstudent where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Student Group Deleted successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MngUpdate_Click(object sender, EventArgs e)
        {
            if (MngAcaademicSemester.Text == "" || MngProgramm.Text == "" || MngGroupNumber.Text == "" || MngSubGroupNumber.Text == "" || MngGroupID.Text == "" || MngSubGroupID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update addstudent set AcademicYearSemester = '" + MngAcaademicSemester.Text + "',Programm = '" + MngProgramm.Text + "',GroupNumber = '" + MngGroupNumber.Text + "',SubGroupNumber = '" + MngSubGroupNumber.Text + "',GroupID = '" + MngGroupID.Text + "',SubGroupID = '" + MngSubGroupID.Text + "'where Id=" + key + ";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Group Updated successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MngGroupNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MngGroupID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTags obj = new ManageTags();
            obj.Show();
            this.Hide();
        }

        private void MngAcaademicSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MngStudentsGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
