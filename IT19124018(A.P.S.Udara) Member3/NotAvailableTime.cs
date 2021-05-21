using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITPM.Resources
{
    public partial class NotAvailableTime : Form
    {

        MgtNotAvailbleTime man = new MgtNotAvailbleTime();

        public NotAvailableTime()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

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
        }

        private void clearNtAvTim_Click(object sender, EventArgs e)
        {
            selectLectNtAvTim.Text = "";
            selectGrpLectNtAvTim.Text = "";
            selectSGrpNtAvTim.Text = "";
            selectSessIDNtAvTim.Text = "";
            timeNtAvTim.Text = "";
        }
    }
}
