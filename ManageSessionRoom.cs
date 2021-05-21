using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ITPM_Final
{
    public partial class ManageSessionRoom : Form
    {
        public ManageSessionRoom()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
        public int key = 0;
        private void populate()
        {
            con.Open();
            string query = "select * from RoomTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

        }

        private void ManageSessions_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Roomtxt.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

            if (Roomtxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Roomtxt.Text == "")
            {
                MessageBox.Show("Missing Infomation!");
            }
            else
            {
                try
                {


                   
                    string Query = "update RoomTable set Room = '" + Roomtxt.Text + "'where ID=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Updated");
                    con.Close();
                    populate();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignSessions mngloc = new AssignSessions();
            mngloc.ShowDialog();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AssignSessions obj = new AssignSessions();
            obj.Show();
            this.Hide();
        }
    }
}
