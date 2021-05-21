using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using ITPM.Resources;

namespace ITPM
{
    public partial class Overlapping_N : Form
    {
        public Overlapping_N()
        {
            InitializeComponent();
            populate5();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");


        public void populate5()
        {
            conec.Open();
            string Query = "select * from Sessions";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OverLappingNGridView.DataSource = ds.Tables[0];
            conec.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        int key = 0;

        private void OverLappingNGridView_MouseClick(object sender, MouseEventArgs e)
        {
            key = Convert.ToInt32(OverLappingNGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                conec.Open();
                SqlCommand cmd = new SqlCommand("insert into Nonoverlapping values('" + OverLappingNGridView.SelectedRows[0].Cells[1].Value.ToString() + "','" + OverLappingNGridView.SelectedRows[0].Cells[2].Value.ToString() + "','" + OverLappingNGridView.SelectedRows[0].Cells[3].Value.ToString() + "','" + OverLappingNGridView.SelectedRows[0].Cells[4].Value.ToString() + "','" + OverLappingNGridView.SelectedRows[0].Cells[5].Value.ToString() + "','" + OverLappingNGridView.SelectedRows[0].Cells[6].Value.ToString() + "')", conec);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
                conec.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Parallel obj = new Parallel();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Consecutive obj = new Consecutive();
            obj.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NonOverLappingSessionView obj = new NonOverLappingSessionView();
            obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NotAvailableTime obj = new NotAvailableTime();
            obj.Show();
            this.Hide();
        }
    }
}
