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

namespace Csharp_HW
{
    public partial class StudentsGrade : Form
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }

        Cstudent cst = new Cstudent();


        private void btnADD_Click(object sender, EventArgs e)
        {
            cst.name = txtName.Text;
            cst.chi = int.Parse(txtChi.Text);
            cst.eng = int.Parse(txtEng.Text);
            cst.math = int.Parse(txtMath.Text);

            Dictionary<string, int> allClass = new Dictionary<string, int>();
            allClass.Add("國文", Convert.ToInt32(txtChi.Text));
            allClass.Add("英文", Convert.ToInt32(txtEng.Text));
            allClass.Add("數學", Convert.ToInt32(txtMath.Text));

            var maxValueKey = allClass.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            var maxvalue = allClass.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;

            var minValueKey = allClass.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

            var minvalue = allClass.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;

            txtShow1.Text += $"{string.Format(cst.name)}　{cst.chi:##}　{cst.eng:##}　{cst.math:##}　{cst.chi + cst.eng + cst.math:##}　{(cst.chi + cst.eng + cst.math) / 3:##}　{minValueKey}{minvalue}分　{maxValueKey}{maxvalue}分\r\n";

        }
    }
}
