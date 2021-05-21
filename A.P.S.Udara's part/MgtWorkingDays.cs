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
    public partial class MgtWorkingDays : Form
    {
        public MgtWorkingDays()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection conec = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\projectDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddWorkingDays obj = new AddWorkingDays();
            obj.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManageWorkingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void populate()
        {
            conec.Open();
            string Query = "select * from workDH";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conec);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ManageWorkingData.DataSource = ds.Tables[0];
            conec.Close();

        }


        int key = 0;


        private void ManageWorkingData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            NoOfWorkingDays2.Text = ManageWorkingData.SelectedRows[0].Cells[1].Value.ToString();
            WorkingTimeHours2.Text = ManageWorkingData.SelectedRows[0].Cells[2].Value.ToString();
            WorkingTimeMinutes2.Text = ManageWorkingData.SelectedRows[0].Cells[3].Value.ToString();

            if (NoOfWorkingDays2.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ManageWorkingData.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void NoOfWorkingDays2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MgtWorkingDaysDeleteAllBtn2_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from workDH where Id=" + key + ";", conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Working Days And Hours Deleted successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MgtWorkingDaysUpdateBtn2_Click(object sender, EventArgs e)
        {
            if (NoOfWorkingDays2.Text == "" || WorkingTimeHours2.Text == "" || WorkingTimeMinutes2.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update workDH set NoOfWorkingDays = '" + NoOfWorkingDays2.Text + "',Hours = '" + WorkingTimeHours2.Text + "',Minutes = '" + WorkingTimeMinutes2.Text + "'where Id="+key+";";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(Query, conec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Working Days And Hours Updated successfully");
                    conec.Close();

                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Sunday2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MgtWorkingDaysClearBtn2_Click(object sender, EventArgs e)
        {
          
            NoOfWorkingDays2.Text = "";
            WorkingTimeHours2.Text = "";
            WorkingTimeMinutes2.Text = "";
           
        }

        private void Monday2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tuesday2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Wednesday2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Thursday2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
