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
    public partial class NonOverLappingSessionView : Form
    {
        public NonOverLappingSessionView()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populate()
        {
            conec.Open();
            string Query = "select * from Nonoverlapping";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conec.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Overlapping_N obj = new Overlapping_N();
            obj.Show();
            this.Hide();
        }
    }
}
