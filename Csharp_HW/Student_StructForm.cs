using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Csharp_HW.Class1;

namespace Csharp_HW
{
    public partial class Student_StructForm : Form
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }

        Cstudent cst = new Cstudent();

        private void button1_Click(object sender, EventArgs e)
        {
            cst.name = txtname.Text;
            cst.chi = int.Parse(txtChineseScore.Text);
            cst.eng = int.Parse(txtEnglishScore.Text);
            cst.math = int.Parse(txtMathScore.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = $"姓名{cst.name}\r\n國文: {cst.chi}分\r\n英文: {cst.eng}分\r\n數學: {cst.math}分\r\n";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> allClass = new Dictionary<string, int>();
            allClass.Add("國文", Convert.ToInt32(txtChineseScore.Text));
            allClass.Add("英文", Convert.ToInt32(txtEnglishScore.Text));
            allClass.Add("數學", Convert.ToInt32(txtMathScore.Text));

            var maxValueKey = allClass.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            
            var maxvalue = allClass.Aggregate((x,y) => x.Value > y.Value ? x : y).Value;

            var minValueKey = allClass.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

            var minvalue = allClass.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;


            txt1.Text = $"最高科目為 {maxValueKey}{maxvalue}分\r\n最低科目為 {minValueKey}{minvalue}分";
        }
    }
}
