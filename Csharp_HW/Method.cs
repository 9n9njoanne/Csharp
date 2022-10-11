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
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            bool isNum = int.TryParse(textBox1.Text, out i);
            if (isNum)
                if (i % 2 == 0)
                {

                    label3.Text = $"輸入的數 { textBox1.Text}為 偶數";
                }

                else
                {
                    label3.Text = $"輸入的數 {textBox1.Text} 為 奇數";
                }
            else
            {
                MessageBox.Show($"請輸入正確的數值");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] Myarr = new int[10] { 2, 4, 5, 10, 54, 77, 89, 100, 105, 200 };
            label3.Text = $"int陣列arr[2, 4, 5, 10, 54, 77, 89,\r\n 100, 105, 200]\r\n" +
                $"最大值 {Myarr.Max()}\r\n最小值{Myarr.Min()}";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] Myarr = new int[10] { 2, 4, 5, 10, 54, 77, 89, 100, 105, 200 };
            int count = 0;
            for (int i = 0; i < Myarr.Length; i++)
            {
                if (Myarr[i] % 2 == 0)
                {
                    count++;
                }
            }

            label3.Text = $"int陣列arr[2, 4, 5, 10, 54, 77, 89,\r\n 100, 105, 200]\r\n" +
                $"奇數共 {Myarr.Length - count} 個\r\n偶數共 {count} 個";
        }


        private void button9_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            Swap(ref a, ref b);
            label3.Text = $"換位前a = 100, b= 200 \r\n換位後a = {a}, b = {b}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] Myarr = new int[10] { 2, 4, 5, 10, 54, 77, 89, 100, 105, 485 };

            label3.Text = $"int陣列arr[2, 4, 5, 10, 54, 77, 89,\r\n 100, 105, 200]\r\n加總為{ Myarr.Sum() }";

        }


        private void button5_Click(object sender, EventArgs e)
        {
            string[] Name = new string[8] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

            label3.Text = "";

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i].Length > i)
                {

                    label3.Text = $"陣列[mother張, emma, 迪克蕭, J40,\r\n Candy, Cindy, Coconut, Motherfacker]\r\n" +
                        $"最長的名字為 {Name[i]}";
                }

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] Name = new string[8] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

            label3.Text = "";
            int Count = 0;

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i].Contains("C")|| Name[i].Contains("c"))
                {
         
                    Count++;

                    label3.Text = $"陣列[mother張, emma, 迪克蕭, J40,\r\n Candy, Cindy, Coconut, Motherfacker]\r\n" +
                        $"含有 C 及 c 的名字有 {Count} 個";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] Myarr = new int[10] { 2, 4, 5, 10, 54, 77, 89, 100, 105, 485 };


            label3.Text = $"int陣列arr[2, 4, 5, 10, 54, 77, 89,\r\n 100, 105, 200]\r\n最小值為{ Myarr.Min() }";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] Myarr = new int[10] { 2, 4, 5, 10, 54, 77, 89, 100, 105, 485 };

            label3.Text = $"int陣列arr[2, 4, 5, 10, 54, 77, 89,\r\n 100, 105, 200]\r\n最大值為{ Myarr.Max() }";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (i==0 || j==0 || i==9 || j==9)
                    {
                        label3.Text += $" {arr[i, j] = 1} ";
                    }
                    else
                    {
                        label3.Text += $" {arr[i, j] = 0} ";
                    }
                }
                label3.Text += "\n";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        label3.Text += $" {arr[i, j] = 0} ";
                    }
                    else
                    {
                        label3.Text += $" {arr[i, j] = 1} ";
                    }
                }
                label3.Text += "\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (i ==0 && j==0 || i%2==0 && j%2==0 || i == j || (i+j)%2 == 0)
                    {
                        label3.Text += $" {arr[i, j] = 1} ";
                    }
                    else
                    {
                        label3.Text += $" {arr[i, j] = 0} ";
                    }
                }
                label3.Text += "\n";
            }
        }
    }
}
