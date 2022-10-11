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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strEnName = txtEnName.Text;
            string strSex = txtSex.Text;
            String strStar = txtStar.Text;
            MessageBox.Show("Hello, 我是" + strName + "," + Environment.NewLine + "英文名字是 " + strEnName + "," + Environment.NewLine + "性別是 " + strSex + "," + Environment.NewLine + "星座是 " + strStar + "," + Environment.NewLine + "nice to meet you. :)");
            // Text = strName;
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strEnName = txtEnName.Text;
            string strSex = txtSex.Text;
            String strStar = txtStar.Text;
            MessageBox.Show("Hi, 我是" + strName + "," + Environment.NewLine + "英文名字是 " + strEnName + "," + Environment.NewLine + "性別是 " + strSex + "," + Environment.NewLine + "星座是 " + strStar + "," + Environment.NewLine + "nice to meet you. :)");
        }
    }
}
