using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Csharp_HW.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_HW
{
    public partial class Loan : Form
    { 

        public Loan()
        {
            InitializeComponent();

        }

        public static int money;
        public static int year;
        public static int rate;
        public static int FirstMoney;
        public static int total;

        private void btnPMT_Click(object sender, EventArgs e)
        {
            Loancls loa = new Loancls();
            
            loa.money = double.Parse(txtMoney.Text);
            loa.year = double.Parse(txtYear.Text);
            loa.rate = double.Parse(txtRate.Text);
            loa.FirstMoney = double.Parse(txtFirstMoney.Text);

            double month = loa.year * 12;
            // 還款總月數＝貸款年期×12

            double monthRate = loa.rate / 12 / 100;
            // 月利率＝年利率÷12

            double r = 1 + monthRate;
            // 1+月利率

            double x = Math.Pow(r, month);
            // (1＋月利率)^月數

            double PMT = loa.money * (x * monthRate) / (x - 1);
            // 每月應攤付本息金額 ＝貸款金額*{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            int i = (int)Math.Floor(PMT);

            MessageBox.Show("月付金額: " + i);

        }

        private void btnSumpay_Click(object sender, EventArgs e)
        {
            Loancls loa = new Loancls();

            loa.money = double.Parse(txtMoney.Text);
            loa.year = double.Parse(txtYear.Text);
            loa.rate = double.Parse(txtRate.Text);
            loa.FirstMoney = double.Parse(txtFirstMoney.Text);

            double month = loa.year * 12;
            // 還款總月數＝貸款年期×12

            double monthRate = loa.rate / 12 / 100;
            // 月利率＝年利率÷12

            double r = 1 + monthRate;
            // 1+月利率

            double x = Math.Pow(r, month);
            // (1＋月利率)^月數

            double PMT = loa.money * (x * monthRate) / (x - 1);
            int i = (int)Math.Floor(PMT);
            // 月付金額

            double s = i * month;
            total = (int)Math.Ceiling(s);
            // 總付款額 ＝{貸款金額*{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}}*還款總月數
            //         = 月付金額*還款總月數
            MessageBox.Show("總付款額: " + total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             money = int.Parse(txtMoney.Text);
             year = int.Parse(txtYear.Text);
             rate= int.Parse(txtRate.Text);
             FirstMoney = int.Parse(txtFirstMoney.Text);

            Loancls loa = new Loancls();

            loa.money = double.Parse(txtMoney.Text);
            loa.year = double.Parse(txtYear.Text);
            loa.rate = double.Parse(txtRate.Text);
            loa.FirstMoney = double.Parse(txtFirstMoney.Text);

            double month = loa.year * 12;
            // 還款總月數＝貸款年期×12

            double monthRate = loa.rate / 12 / 100;
            // 月利率＝年利率÷12

            double r = 1 + monthRate;
            // 1+月利率

            double x = Math.Pow(r, month);
            // (1＋月利率)^月數

            double PMT = loa.money * (x * monthRate) / (x - 1);
            int i = (int)Math.Floor(PMT);
            // 月付金額

            double s = i * month;
            total = (int)Math.Ceiling(s);
            // 總付款額 ＝{貸款金額*{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}}*還款總月數
            //         = 月付金額*還款總月數


            LoanReport lr = new LoanReport();
            //這邊就是傳遞自己的參考指標給Form2的Owner屬性
            lr.Show();
        }
    }
}
