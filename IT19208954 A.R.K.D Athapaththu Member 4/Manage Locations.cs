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
    public partial class ManageLocations : Form
        
    {
 
        public ManageLocations()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\LocationD.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;

        private void populate()
        {
            con.Open();
            string query = "select * from LocTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
    

        private void clear()
        {
          
            Buildtxt.Text = "";
            Roomtxt.Text = "";
            comboBox1.SelectedIndex = -1;
            capacitytxt.Text = "";
            key = 0;
        }


        private void ManageLocations_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Buildtxt.Text == "" || Roomtxt.Text == "" || comboBox1.Text == "" || capacitytxt.Text == "")
            {
                MessageBox.Show("Missing Infomation!");
            }
            else
            {
                try
                {



                    string Query = "update LocTable set BuildingName = '" + Buildtxt.Text + "',Room = '" + Roomtxt.Text + "',RoomType = '" + comboBox1.Text + "',Capacity = '" + capacitytxt.Text + "'where ID=" + key + ";";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Enter ID");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from LocTable where ID =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            Buildtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Roomtxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            capacitytxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (Buildtxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
    }
}
