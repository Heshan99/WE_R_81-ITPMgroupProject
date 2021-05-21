using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITPM_Final
{
    public partial class AddNewLocation : Form
    {
        public AddNewLocation()
        {
            InitializeComponent();
        }
        String RoomType;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\LocationD.mdf;Integrated Security=True;Connect Timeout=30");

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton1.Checked = false;
            numericUpDown1.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageLocations mngloc = new ManageLocations();
            mngloc.ShowDialog();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Insert Data");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "Insert into LocTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + RoomType + "','" + numericUpDown1.Value + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Entered");
                    con.Close();
                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Lecture Hall";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Lab";
        }
    }
    
}
