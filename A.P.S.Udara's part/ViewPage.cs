using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITPM
{
    public partial class ViewPage : Form
    {
        public ViewPage()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populate()
            {
                conec.Open();
                string Query = "select * from workingDH";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                viewData.DataSource = ds.Tables[0];
                conec.Close();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorkingDays obj = new AddWorkingDays();
            obj.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
