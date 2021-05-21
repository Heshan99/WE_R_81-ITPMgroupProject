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
    public partial class MgtNotAvailbleTime : Form
    {
        public MgtNotAvailbleTime()
        {
            InitializeComponent();
            populate();


        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\projectDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populate()
        {
            conec.Open();
            string Query = "select * from notAvatime";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            mgtNotAvaTime.DataSource = ds.Tables[0];
            conec.Close();

        }
        int key = 0;

        private void deleteMgtNtAvaT_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Data to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from notAvatime where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Not Available Time Deleted successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void mgtNotAvaTime_MouseClick(object sender, MouseEventArgs e)
        {
            key = Convert.ToInt32(mgtNotAvaTime.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void backMgtNtAvaT_Click(object sender, EventArgs e)
        {
           NotAvailableTime obj = new NotAvailableTime();
            obj.Show();
        }
    }
}
