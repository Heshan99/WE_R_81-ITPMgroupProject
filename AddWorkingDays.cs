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
using webapp1;
using ABC;

namespace ITPM
{
    public partial class AddWorkingDays : Form
    {
        
        


        public AddWorkingDays()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {





































































































































































































































































































































































































































































































































































































































        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MgtWorkingDays obj = new MgtWorkingDays();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (NoOfWorkingDays.Text == "" ||  WorkingTimeMinutes1.Text == "" || WorkingTimeHours1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into workDH values('" + NoOfWorkingDays.Text + "','" + WorkingTimeHours1.Text + "','" + WorkingTimeMinutes1.Text + "')", con); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("WorkingDays added successfully");
                    con.Close();

                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

            
        }

        private void NoOfWorkingDays1_ValueChanged(object sender, EventArgs e)
        {
            

                int countCB = 0;
                int countTB = 0;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        countCB++;
                    }
                    else if (c.GetType() == typeof(TextBox))
                    {
                        countTB++;
                    }
                }

            /*countCB.Write("No of TextBoxes: " + countTB);
            countCB.Write("<br>");
            countCB.Write("No of CheckBoxes: " + countCB);*/
            



        }

        private void AddWorkingDaysViewBtn1_Click(object sender, EventArgs e)
        {
            ViewPage obj = new ViewPage();
            obj.Show();
            this.Hide();
        }

        private void NoOfWorkingDays1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void AddWorkingDaysClearBtn1_Click(object sender, EventArgs e)
        {
            NoOfWorkingDays.Text = "";
            WorkingTimeHours1.Text = "";
            WorkingTimeMinutes1.Text = "";
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sunday1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WorkingTimeHours1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void AddLocation1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    } }
