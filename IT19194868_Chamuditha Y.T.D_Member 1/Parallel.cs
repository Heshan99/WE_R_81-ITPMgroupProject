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
    public partial class Parallel : Form
    {
        public Parallel()
        {
            InitializeComponent();
            populate4();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tdils\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");



        public void populate4()
        {
            conec.Open();
            string Query = "select * from Sessions";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ParellelDataGrid.DataSource = ds.Tables[0];
            conec.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("insert into Parallel values('" + ParellelDataGrid.SelectedRows[0].Cells[1].Value.ToString() + "','" + ParellelDataGrid.SelectedRows[0].Cells[2].Value.ToString() + "','" + ParellelDataGrid.SelectedRows[0].Cells[3].Value.ToString() + "','" + ParellelDataGrid.SelectedRows[0].Cells[4].Value.ToString() + "','" + ParellelDataGrid.SelectedRows[0].Cells[5].Value.ToString() + "','" + ParellelDataGrid.SelectedRows[0].Cells[6].Value.ToString() + "')", conec);
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
        private void Parallel_MouseClick(object sender, MouseEventArgs e)
        {
            key = Convert.ToInt32(ParellelDataGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consecutive obj = new Consecutive();
            obj.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ParallelSessionView obj = new ParallelSessionView();
            obj.Show();
        }
    }
}
