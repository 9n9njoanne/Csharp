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
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            float num1, num2;
            float.TryParse(txtNum1.Text, out num1);
            float.TryParse(txtNum2.Text, out num2);
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            txtAns.Text = (num1 + num2).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float num1, num2;
            float.TryParse(txtNum1.Text, out num1);
            float.TryParse(txtNum2.Text, out num2);
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            txtAns.Text = (num1 - num2).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float num1, num2;
            float.TryParse(txtNum1.Text, out num1);
            float.TryParse(txtNum2.Text, out num2);
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            txtAns.Text = (num1 * num2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入正確的值");
                return;
            }
            double i = num1 / num2;
            double s = Math.Round(i, 4);
            txtAns.Text = s.ToString();
        }
    }
}
