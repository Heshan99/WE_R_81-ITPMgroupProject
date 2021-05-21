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
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NoOfWorkingDays_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addLoc_Click(object sender, EventArgs e)
        {
            if (selectRoomLoc.Text == "" || selectDayLoc.Text == "" ||  startTimeLoc.Text == "" || endTimeLoc.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into location values('" + selectRoomLoc.Text + "','" + selectDayLoc.Text + "','" + startTimeLoc.Text + "','" + endTimeLoc.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location added successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void clearLoc_Click(object sender, EventArgs e)
        {
            selectRoomLoc.Text = "";
            selectDayLoc.Text = "";
            startTimeLoc.Text = "";
            endTimeLoc.Text = "";
        }
    }
}
