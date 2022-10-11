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
    public partial class m2 : Form
    {
        public m2()
        {
            InitializeComponent();
        }


        private void btnFor_Click(object sender, EventArgs e)
        {
            int i, from, to, k, sum = 0;
            from = Convert.ToInt32(txtFrom.Text);
            to = Convert.ToInt32(txtTo.Text);
            k = Convert.ToInt32(txtStep.Text);

            if (string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            else
            {
                for (i = from; i <= to; i += k)
                {
                    sum = sum + i;
                    label3.Text = $"{from}到{to}相隔{k}\n加總為{sum}";
                }

            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i, from, to, k, sum = 0;
            i = Convert.ToInt32(txtFrom.Text);
            from = Convert.ToInt32(txtFrom.Text);
            to = Convert.ToInt32(txtTo.Text);
            k = Convert.ToInt32(txtStep.Text);

            if (string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            else
            {
                while (from <= to)
                {
                    sum = sum + from;
                    from += k;
                }
                label3.Text = $"{i}到{to}相隔{k}\n加總為{sum}";

            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int i, from, to, k, sum = 0;
            i = Convert.ToInt32(txtFrom.Text);
            from = Convert.ToInt32(txtFrom.Text);
            to = Convert.ToInt32(txtTo.Text);
            k = Convert.ToInt32(txtStep.Text);

            if (string.IsNullOrEmpty(txtFrom.Text) || string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            else
            {
                do
                {
                    sum = sum + from;
                    from += k;
                } while (from <= to);

                label3.Text = $"{i}到{to}相隔{k}\n加總為{sum}";
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            label3.Text = "";

            int j = int.Parse(txtRow.Text);

            for (int i = 1; i <= j; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    label3.Text += $"*";
                }
                label3.Text += $"\r\n";
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int i = 100;
            string result = Convert.ToString(i, 2);
            label3.Text = $"{result}";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int[] randomball = new int[6];
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomball[i] = rd.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    while (randomball[j] == randomball[i])
                    {
                        j = 0;
                        randomball[i] = rd.Next(1, 50);
                    }
                }

            }
            label3.Text = $"樂透號碼\n{randomball[0].ToString()} {randomball[1].ToString()} {randomball[2].ToString()} {randomball[3].ToString()} {randomball[4].ToString()} {randomball[5].ToString()}";
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            string data = "";
            for (int i = 2; i < 10; i += 8)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = i; k < (i + 8); k++)
                    {
                        data += $" {k} x {j} = {(k * j).ToString("00")}｜\t";
                    }
                    data += "\n";
                }

            }
            label3.Text = data;
        }
    }
}
