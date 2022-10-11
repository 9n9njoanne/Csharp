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
    public partial class General_table : Form
    {
        public General_table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hello hellow = new Hello();
            hellow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_StructForm ssf = new Student_StructForm();
            ssf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentsGrade sg = new StudentsGrade();
            sg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Method method = new Method();
            method.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyClac mycl = new MyClac();
            mycl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XOGame xo = new XOGame();
            xo.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Picture_Viewer pv = new Picture_Viewer();
            pv.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Student_StructForm ssf = new Student_StructForm();
            ssf.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            m2 m2 = new m2();
            m2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentsGrade sg = new StudentsGrade();
            sg.Show();
        }
    }
}
