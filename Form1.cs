using ITPM;
using ITPM_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webapp1;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLecturers obj = new AddLecturers();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddWorkingDays obj = new AddWorkingDays();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudentsGroups obj = new AddStudentsGroups();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSession obj = new AddSession();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewLocation obj = new AddNewLocation();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Statistics obj = new Statistics();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Generate obj = new Generate();
            obj.Show();
            this.Hide();
        }
    }
}
