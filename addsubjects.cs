using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace webapp1
{
    public partial class addsubjects : Form
    {
        managesubjects man2 = new managesubjects();
        public addsubjects()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            AddLecturers obj3 = new AddLecturers();
            obj3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageLecturer obj = new ManageLecturer();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            managesubjects obj2 = new managesubjects();
            obj2.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ofyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbb_Click(object sender, EventArgs e)
        {
            ofyear.Text = "";
            ofsem.Text = "";
            subname.Text = "";
            subcode.Text = "";
            lechours.Text = "";
            tutehours.Text = "";
            labhours.Text = "";
            evalhours.Text = "";
        }

        private void savebb_Click(object sender, EventArgs e)
        {
            if (ofyear.Text == "" || ofsem.Text == "" || subname.Text == "" || subcode.Text == "" || lechours.Text == "" || tutehours.Text == "" || labhours.Text == "" || evalhours.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Subjects values('" + ofyear.Text + "','" + ofsem.Text + "','" + subname.Text + "','" + subcode.Text + "','" + lechours.Text + "','" + tutehours.Text + "','" + labhours.Text + "','" + evalhours.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject added successfully");
                    con.Close();
                    man2.populate2();

                    

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();
        }

        private void addsubjects_Load(object sender, EventArgs e)
        {

        }
    }
}
