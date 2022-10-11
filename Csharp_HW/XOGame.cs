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
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }

        bool isX = true;

        private void testWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
                
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show($"X Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show($"O Win !!!");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button1.Text = "X";

            }
            else
            {
                button1.Text = "O";

            }

            button1.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }

            isX = !isX;
            button2.Enabled = false;
            testWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }

            button3.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }

            button4.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }

            button5.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }

            button6.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }

            button7.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }

            button8.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }

            button9.Enabled = false;
            isX = !isX;
            testWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
