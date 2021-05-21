using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using webapp1;

namespace ITPM_Final
{
    public partial class AssignSessions : Form
    {
        public AssignSessions()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
        public int key = 0;
        private void populate()
        {
            con.Open();
            string query = "select * from Sessions";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();

        }

        private void clear()
        {

            Lnametxt.Text = "";
            tagtxt.Text = "";
            subject.Text = "";
            gid.Text = "";
            nhours.Text = "";
            dur.Text = "";
            roomtxt.Text = "";

        }

        private void ManageSessionRooms_Load(object sender, EventArgs e)
        {

            populate();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Lnametxt.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            tagtxt.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            gid.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            subject.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            nhours.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            dur.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
    
            if (Lnametxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Lnametxt.Text == "" || tagtxt.Text == "" || nhours.Text == "" || subject.Text == "" || gid.Text == "" || dur.Text == "" || roomtxt.Text == "")
            {
                MessageBox.Show("Insert Data");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "Insert into RoomTable values('" + Lnametxt.Text + "','" + tagtxt.Text + "','" + nhours.Text + "','" + subject.Text + "','" + gid.Text + "','" + dur.Text + "','" + roomtxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Successfully Entered");
                    con.Close();
                    clear();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managesessionrooms_Click(object sender, EventArgs e)
        {
            ManageSessionRoom obj = new ManageSessionRoom();
            obj.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();

        }
    }
}
