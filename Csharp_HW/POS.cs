using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static Csharp_HW.Class1;

namespace Csharp_HW
{
    public partial class POS : Form
    {
        List<Product> teas = new List<Product>();

        public POS()
        {
            InitializeComponent();
        }
        void showtp()
        {
            string list = "";
            foreach (Product tea in teas)
            {
                list += $"{tea.name} x {tea.count}, 共NT$ {tea.Price * tea.count}\r\n";
            }

            txtTotalPrice.Text = $"NT$ {GetTotalPrice()}";
            txtlist.Text = list;
        }

        private void AddTea(string name, int price)
        {
            bool isExist = false;
            foreach (Product tea in teas)
            {
                if (tea.name == name)
                {
                    tea.count++;
                    isExist = true;
                    break;
                }
            }

            Product newTea = new Product();
            if(isExist == false)
            {
                newTea.name = name;
                newTea.Price = price;
                newTea.count = 1;
                teas.Add(newTea);

            }
        }

        private int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (Product tea in teas)
            {
                totalPrice += tea.count * tea.Price;
            }
            return totalPrice;
        }

        private void btnBlackTea_Click(object sender, EventArgs e)
        {
            AddTea("啤酒Beer", 120);
            showtp();
        }

        private void btnGreenTea_Click(object sender, EventArgs e)
        {
            AddTea("龍舌蘭Tequila", 180);
            showtp();
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            AddTea("威士忌Whishy", 350);
            showtp();
        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {
            AddTea("紅酒Wine", 320);
            showtp();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {GetTotalPrice()}", "確認金額");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {GetTotalPrice()}\n折扣後金額: {GetTotalPrice() * 0.9}", "確認金額");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtlist.Clear();
            txtTotalPrice.Clear();
        }
    }
}
