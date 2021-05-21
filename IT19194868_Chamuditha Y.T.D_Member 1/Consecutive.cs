using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITPM
{
    public partial class Consecutive : Form
    {
        public Consecutive()
        {
            InitializeComponent();
            populate();
        }


        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tdils\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");


        public void populate()
        {
            conec.Open();
            string Query = "select * from Sessions";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ConsGrid.DataSource = ds.Tables[0];
            conec.Close();

        }

        private void ConsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Parallel obj = new Parallel();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Overlapping_N obj = new Overlapping_N();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("insert into Consecutive values('" + ConsGrid.SelectedRows[0].Cells[1].Value.ToString() + "','" + ConsGrid.SelectedRows[0].Cells[2].Value.ToString() + "','" + ConsGrid.SelectedRows[0].Cells[3].Value.ToString() + "','" + ConsGrid.SelectedRows[0].Cells[4].Value.ToString() + "','" + ConsGrid.SelectedRows[0].Cells[5].Value.ToString() + "','" + ConsGrid.SelectedRows[0].Cells[6].Value.ToString() + "')", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                    conec.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            
        }


        int key = 0;

        private void ConsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            key = Convert.ToInt32(ConsGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ConsecutiveSessionView obj = new ConsecutiveSessionView();
            obj.Show();
        }
    }
}
