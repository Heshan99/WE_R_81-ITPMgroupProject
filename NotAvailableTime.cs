using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using webapp1;

namespace ITPM.Resources
{
    public partial class NotAvailableTime : Form
    {

        MgtNotAvailbleTime man = new MgtNotAvailbleTime();

        public NotAvailableTime()
        {
            InitializeComponent();
            fillcombobox();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consecutive obj = new Consecutive();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Parallel obj = new Parallel();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void selectLectNtAvTim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillcombobox()
        {
            string sql = "select * from Sessions";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    string sname2 = myreader.GetString(3);
                    string sname1 = myreader.GetInt32(0).ToString();
                    selectLectNtAvTim.Items.Add(sname);
                    selectGrpLectNtAvTim.Items.Add(sname2);
                    selectSGrpNtAvTim.Items.Add(sname2);
                    selectSessIDNtAvTim.Items.Add(sname1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void saveNtAvTim_Click(object sender, EventArgs e)
        {
            if (selectLectNtAvTim.Text == "" || selectGrpLectNtAvTim.Text == "" || selectSGrpNtAvTim.Text == "" || selectSessIDNtAvTim.Text == "" || timeNtAvTim.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into notAvatime values('" + selectLectNtAvTim.Text + "','" + selectGrpLectNtAvTim.Text + "','" + selectSGrpNtAvTim.Text + "','" + selectSessIDNtAvTim.Text + "','" + timeNtAvTim.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Not availble time added successfully");
                    con.Close();

                    man.populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void viewNtAvTim_Click(object sender, EventArgs e)
        {
            MgtNotAvailbleTime obj = new MgtNotAvailbleTime();
            obj.Show();
            this.Hide();
        }

        private void clearNtAvTim_Click(object sender, EventArgs e)
        {
            selectLectNtAvTim.Text = "";
            selectGrpLectNtAvTim.Text = "";
            selectSGrpNtAvTim.Text = "";
            selectSessIDNtAvTim.Text = "";
            timeNtAvTim.Text = "";
        }

        private void NotAvaTim_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Overlapping_N obj = new Overlapping_N();
            obj.Show();
            this.Hide();
        }

        private void selectLectNtAvTim_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Close();
        }
    }
}
