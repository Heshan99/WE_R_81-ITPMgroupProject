using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace webapp1
{
    public partial class ManageLecturer : Form
    {
        public ManageLecturer()
        {
            InitializeComponent();
            populate();
            
        }
        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
        /* DBAccess objDbAccess = new DBAccess();
         DataTable dtUsers = new DataTable();*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           /* string Query = "select * from Lecturers";
            objDbAccess.readDatathroughAdapter(Query,dtUsers);
            lectab.DataSource = dtUsers;
            objDbAccess.closeConn();*/
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLecturers obj = new AddLecturers();
            obj.Show();
            ManageLecturer obj2 =  new ManageLecturer();
            obj2.Close();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            /*lecnameman.Text = lectab.SelectedRows[0].Cells[1].Value.ToString();
            empidman.Text = lectab.SelectedRows[0].Cells[2].Value.ToString();
            facman.Text = lectab.SelectedRows[0].Cells[3].Value.ToString();
            levman.Text = lectab.SelectedRows[0].Cells[4].Value.ToString();
            depman.Text = lectab.SelectedRows[0].Cells[5].Value.ToString();
            cenman.Text = lectab.SelectedRows[0].Cells[6].Value.ToString();
            buildman.Text = lectab.SelectedRows[0].Cells[7].Value.ToString();
            rankman.Text = lectab.SelectedRows[0].Cells[8].Value.ToString();

            if (lecnameman.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(lectab.SelectedRows[0].Cells[0].Value.ToString());
            }*/

            
        }
        public void populate()
        {
           conec.Open();
            string Query = "select * from Lecturers";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            lectab.DataSource = ds.Tables[0];
            conec.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lectab_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* lecnameman.Text = lectab.SelectedRows[0].Cells[1].Value.ToString();
             empidman.Text = lectab.SelectedRows[0].Cells[2].Value.ToString();
             facman.Text = lectab.SelectedRows[0].Cells[3].Value.ToString();
             levman.Text = lectab.SelectedRows[0].Cells[4].Value.ToString();
             depman.Text = lectab.SelectedRows[0].Cells[5].Value.ToString();
             cenman.Text = lectab.SelectedRows[0].Cells[6].Value.ToString();
             buildman.Text = lectab.SelectedRows[0].Cells[7].Value.ToString();
             rankman.Text = lectab.SelectedRows[0].Cells[8].Value.ToString();*/

            lecnameman.Text = lectab.SelectedRows[0].Cells[1].Value.ToString();
            empidman.Text = lectab.SelectedRows[0].Cells[2].Value.ToString();
            facman.Text = lectab.SelectedRows[0].Cells[3].Value.ToString();
            levman.Text = lectab.SelectedRows[0].Cells[4].Value.ToString();
            depman.Text = lectab.SelectedRows[0].Cells[5].Value.ToString();
            cenman.Text = lectab.SelectedRows[0].Cells[6].Value.ToString();
            buildman.Text = lectab.SelectedRows[0].Cells[7].Value.ToString();
            rankman.Text = lectab.SelectedRows[0].Cells[8].Value.ToString();

            if (lecnameman.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(lectab.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lectab_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int x = 1;
        private void deletelec_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Lecturer to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from Lecturers where Id="+key+";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Lecturer Deleted successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            /*conec.Open();
            SqlCommand cmd = new SqlCommand("delete from Lecturers where EmpId="+empidman.Text+";", conec);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Selected Deleted successfully");
            conec.Close();
            populate();*/



        }

        private void updatelec_Click(object sender, EventArgs e)
        {
            if (lecnameman.Text == "" || empidman.Text == "" || facman.Text == "" || depman.Text == "" || cenman.Text == "" || buildman.Text == "" || levman.Text == "" || rankman.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update Lecturers set Name = '" + lecnameman.Text + "',EmpId = '" + empidman.Text + "',Department = '" + depman.Text + "',Faculty = '" + facman.Text + "',Center = '" + cenman.Text + "',Building = '" + buildman.Text + "',Level = '" + levman.Text + "',Rank = '" + rankman.Text + "'where Id="+key+";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lecturer Updated successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void facman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addsubjects obj = new addsubjects();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            AddLecturers obj = new AddLecturers();
            obj.Show();
            this.Hide();
        }
    }
}
