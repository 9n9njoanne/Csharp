using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Csharp_HW
{
    public partial class LoanReport : Form
    {

        public LoanReport()
        {
            InitializeComponent();
        }

        private void LoanReport_Load(object sender, EventArgs e)
        {
            textBox1.Text = Loan.money.ToString();
            textBox2.Text = Loan.year.ToString();
            textBox3.Text = Loan.rate.ToString();
            textBox4.Text = Loan.FirstMoney.ToString();
            textBox5.Text = Loan.total.ToString();
        }    
        
    }
}
