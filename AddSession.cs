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
using System.Configuration;
using ITPM;
using ITPM_Final;
using ABC;

namespace webapp1
{
    public partial class AddSession : Form
    {
        managesessions man3 = new managesessions();
        public AddSession()
        {
            InitializeComponent();
            fillcombobox();
            subcombobox();
            groupcombobox();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uiui_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void selnostudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSession_Load(object sender, EventArgs e)
        {
            

        }

        public void fillcombobox()
        {
            string sql = "select * from Lecturers";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader; 
                try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    sessionlecnamehj.Items.Add(sname);
                    
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void subcombobox()
        {
            string sql = "select * from Subjects";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
                    subcombo.Items.Add(sname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void groupcombobox()
        {
            string sql = "select * from addstudent";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(6);
                    combogroup.Items.Add(sname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            if (sessionlecnamehj.Text == "" || seltag.Text == "" || combogroup.Text == "" || subcombo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Sessions values('" + sessionlecnamehj.Text + "','" + seltag.Text + "','" + combogroup.Text + "','" + subcombo.Text + "','"+ noofstudentsessions.Text+ "','"+ durationsessions.Text+ "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session added successfully");
                    con.Close();

                    man3.populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void back2_Click(object sender, EventArgs e)
        {

        }
        private void selsub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
private void sellec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            managesessions obj = new managesessions();
            obj.Show();
            this.Hide();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            sessionlecnamehj.Text = "";
            seltag.Text = "";
            noofstudentsessions.Text = "";
            combogroup.Text = "";
            durationsessions.Text = "";
        }

       

        /*private void BindDataReaderData()
        {
            
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Heshan\Documents\projectdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand cmd = new SqlCommand("Select * from Lecturers", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListItem li = new ListItem(rdr["Currency"] + " " #
                        + rdr["Rate"], rdr["Id"].ToString());
                    ddlPrice.Items.Add(li);
                }
            }
        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            


        }

        private void butspeci_Click(object sender, EventArgs e)
        {
            Consecutive obj = new Consecutive();
            obj.Show();
            this.Hide();
        }

        private void assignRooms_Click(object sender, EventArgs e)
        {
            AssignSessions obj = new AssignSessions();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
