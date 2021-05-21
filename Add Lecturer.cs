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
using ABC;

namespace webapp1
{
    public partial class AddLecturers : Form
    {
        ManageLecturer man = new ManageLecturer();
        public AddLecturers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageLecturer obj = new ManageLecturer();
            obj.Show();
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lecname.Text = "";
            empid.Text = "";
            faculty.Text =  "";
            department.Text = "";
            center.Text = "";
            building.Text = "";
            level.Text = "";
            rank.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            string a = level.Text;
            string b = empid.Text;

            string c = a + "." + b;
            rank.Text = c;  
        }

        private void lecname_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void save_Click(object sender, EventArgs e)
        {
            if (lecname.Text == "" || empid.Text == "" || faculty.Text == "" || department.Text == "" || center.Text == "" || building.Text == "" ||level.Text == "" || rank.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Lecturers values('" + lecname.Text + "','" + empid.Text + "','" + faculty.Text + "','" + level.Text + "','" + department.Text + "','" + center.Text + "','" + building.Text + "','" + rank.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lecturer added successfully");
                    con.Close();
                    
                    man.populate();
                  
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }

        private void lectab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addsubjects obj2 = new addsubjects();
            obj2.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            managesubjects obj3 = new managesubjects();
            obj3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            managesessions obj = new managesessions();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void AddLecturers_Load(object sender, EventArgs e)
        {

        }
    }
}
