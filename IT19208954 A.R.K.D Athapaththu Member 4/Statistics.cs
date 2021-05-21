using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ITPM_Final
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();


 
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\LocationD.mdf;Integrated Security=True;Connect Timeout=30");

        private void Statistics_Load(object sender, EventArgs e)
        {
            string query = "select Count(*) from LocTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Loclbl.Text = dt.Rows[0][0].ToString();
            /*
            string query2 = "select Count(*) from LocTable";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            Grouplbl.Text = dt2.Rows[0][0].ToString();

            string query3 = "select Count(*) from LocTable";
            SqlDataAdapter sda3 = new SqlDataAdapter(query, con);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);
            Sublbl.Text = dt3.Rows[0][0].ToString();

            string query4 = "select Count(*) from LocTable";
            SqlDataAdapter sda4 = new SqlDataAdapter(query, con);
            DataTable dt4 = new DataTable();
            sda.Fill(dt4);
            roomlbl.Text = dt4.Rows[0][0].ToString();
            */
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
