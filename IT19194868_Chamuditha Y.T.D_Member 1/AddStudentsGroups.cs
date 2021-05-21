using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITPM
{
    public partial class AddStudentsGroups : Form
    {
        MngStudentsGroups managegroup = new MngStudentsGroups();

        public AddStudentsGroups()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tdils\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MngStudentsGroups obj = new MngStudentsGroups();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentGenarateIDBtn_Click(object sender, EventArgs e)
        {
            string a = AddStudentAcademicYearSemester.Text;
            string b = AddStudentProgramm.Text;
            string c = AddStudentGroupNumber.Text;
            string f = AddStudentSubGroupNumber.Text;

            string d = a + "." + b + "." + c;
            AddStudentGroupID.Text = d;

            string g = a + "." + b + "." + c + "." + f; 
            AddStudentSubGroupID.Text = g; 
        }

        private void AddStudentClearBtn_Click(object sender, EventArgs e)
        {
            AddStudentAcademicYearSemester.Text = "";
            AddStudentProgramm.Text = "";
            AddStudentGroupNumber.Text = "";
            AddStudentSubGroupNumber.Text = "";
            AddStudentGroupID.Text = "";
            AddStudentSubGroupID.Text = ""; 

        }

        private void AddStudentSaveBtn_Click(object sender, EventArgs e)
        {
            if (AddStudentAcademicYearSemester.Text == "" || AddStudentProgramm.Text == "" || AddStudentGroupNumber.Text == "" || AddStudentSubGroupNumber.Text == "" || AddStudentGroupID.Text == "" || AddStudentSubGroupID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into addstudent values('" + AddStudentAcademicYearSemester.Text + "','" + AddStudentProgramm.Text + "','" + AddStudentGroupNumber.Text + "','" + AddStudentSubGroupNumber.Text + "','" + AddStudentGroupID.Text + "','" + AddStudentSubGroupID.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Groups Added Successfully");
                    con.Close();
                    managegroup.populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddTags obj = new AddTags();
            obj.Show();
        }

        private void AddStudentAcademicYearSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTags obj = new ManageTags();
            obj.Show();
        }
    }
}
