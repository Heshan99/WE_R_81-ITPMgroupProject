using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace webapp1
{
    public partial class managesessions : Form
    {
        public managesessions()
        {
            InitializeComponent();
            populate2();
        }
        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            AddLecturers obj = new AddLecturers();
            obj.Show();
            this.Hide();
        }
        public void populate2()
        {
            conec.Open();
            string Query = "select * from Sessions";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            managegrid.DataSource = ds.Tables[0];
            conec.Close();

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        private void managegrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            upsessionlecname.Text = managegrid.SelectedRows[0].Cells[1].Value.ToString();
            updatesessiontag.Text = managegrid.SelectedRows[0].Cells[2].Value.ToString();
            updatesessiongroup.Text = managegrid.SelectedRows[0].Cells[3].Value.ToString();
            updatesessionsubject.Text = managegrid.SelectedRows[0].Cells[4].Value.ToString();
            nosmanagestudents.Text = managegrid.SelectedRows[0].Cells[5].Value.ToString();
            durationsmanagesessions.Text = managegrid.SelectedRows[0].Cells[6].Value.ToString();

            if (upsessionlecname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(managegrid.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (upsessionlecname.Text == "" || updatesessiontag.Text == "" || updatesessiongroup.Text == "" || updatesessionsubject.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update Sessions set lecturername = '" + upsessionlecname.Text + "',tag = '" + updatesessiontag.Text + "',groupId = '" + updatesessiongroup.Text + "',subject = '" + updatesessionsubject.Text + "',noofstudents = '" + nosmanagestudents.Text + "',durations = '" + durationsmanagesessions.Text + "'where Id=" + key + ";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session Updated successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Session to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from Sessions where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Session Deleted Successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managesubjects obj = new managesubjects();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addsubjects obj = new addsubjects();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageLecturer obj = new ManageLecturer();
            obj.Show();
            this.Hide();
        }

        private void updatesessionsubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void managesessions_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();
        }
    }
}
