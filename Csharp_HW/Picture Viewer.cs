using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_HW
{
    public partial class Picture_Viewer : Form
    {
        public Picture_Viewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 cat = new Form1();
            cat.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 cat4 = new Form2();
            cat4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 cat5 = new Form3();
            cat5.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 cat6 = new Form4();
            cat6.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 cat7 = new Form5();
            cat7.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6 cat9 = new Form6();
            cat9.Show();
        }
    }
}
