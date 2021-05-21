using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace webapp1
{
    public partial class managesubjects : Form
    {
        public managesubjects()
        {
            InitializeComponent();
            populate2();
        }
        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void button3_Click(object sender, EventArgs e)
        {
            addsubjects obj = new addsubjects();
            obj.Show();
            this.Hide();
        }
        public void populate2()
        {
            conec.Open();
            string Query = "select * from Subjects";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            subtab.DataSource = ds.Tables[0];
            conec.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageLecturer obj2 = new ManageLecturer();
            obj2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLecturers obj3 = new AddLecturers();
            obj3.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void subtab_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ofyearman.Text = subtab.SelectedRows[0].Cells[1].Value.ToString();
            ofsemman.Text = subtab.SelectedRows[0].Cells[2].Value.ToString();
            subnameman.Text = subtab.SelectedRows[0].Cells[3].Value.ToString();
            subcodeman.Text = subtab.SelectedRows[0].Cells[4].Value.ToString();
            lechoursman.Text = subtab.SelectedRows[0].Cells[5].Value.ToString();
            tuteman.Text = subtab.SelectedRows[0].Cells[6].Value.ToString();
            labhoursman.Text = subtab.SelectedRows[0].Cells[7].Value.ToString();
            evhoursman.Text = subtab.SelectedRows[0].Cells[8].Value.ToString();

            if (ofyearman.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(subtab.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void bb_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Subject to be deleted");
            }
            else
            {
                try
                {
                    conec.Open();
                    SqlCommand cmd = new SqlCommand("delete from Subjects where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected subject Deleted successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        
        private void subtab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebb_Click(object sender, EventArgs e)
        {
            if (ofyearman.Text == "" || ofsemman.Text == "" || subnameman.Text == "" || subcodeman.Text == "" || lechoursman.Text == "" || tuteman.Text == "" || labhoursman.Text == "" || evhoursman.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update Subjects set Offredyear = '" + ofyearman.Text + "',Offredsemester = '" + ofsemman.Text + "',subname = '" + subnameman.Text + "',subcode = '" + subcodeman.Text + "',lechours = '" + lechoursman.Text + "',tutehours = '" + tuteman.Text + "',labhours = '" + labhoursman.Text + "',evhours = '" + evhoursman.Text + "'where Id=" + key + ";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated successfully");
                    conec.Close();

                    populate2();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
