using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Generate : Form
    {
        public Generate()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void Generate_Load(object sender, EventArgs e)
        {

        }
    }
}
