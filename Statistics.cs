using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using webapp1;
using ABC;

namespace ITPM_Final
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            textb();
            textb1();
            textb2();




        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Statistics_Load(object sender, EventArgs e)
        {
            string query = "select Count(*) from LocTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Loclbl.Text = dt.Rows[0][0].ToString();
            
            string query2 = "select Count(*) from addstudent";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Grouplbl.Text = dt2.Rows[0][0].ToString();
            
            string query3 = "select Count(*) from Subjects";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Sublbl.Text = dt3.Rows[0][0].ToString();
            
            string query4 = "select Count(*) from RoomTable";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            roomlbl.Text = dt4.Rows[0][0].ToString();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textb()
        {
            string sql = "select * from Lecturers where id=(select max(id) from Lecturers) ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    Buildtxt.Text = sname;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void textb1()
        {
            string sql = "select * from Subjects where id=(select max(id) from Subjects) ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
                    textBox2.Text = sname;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void textb2()
        {
            string sql = "select * from addstudent where id=(select max(id) from addstudent) ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(6);
                    textBox1.Text = sname;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void Buildtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
