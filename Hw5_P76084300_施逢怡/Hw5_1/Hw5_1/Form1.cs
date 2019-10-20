using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculate the rate(Recursive)
        private static double CompoundInterest(int principal, double rate, int year)
        {
            double result_rate;
            if (year < 1)
                return 1;
            result_rate = (1 + (rate)) * CompoundInterest(principal, rate, year - 1);
            return result_rate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_price.Text == "" || textBox_rate.Text == "" || textBox_year.Text == "")
            {
                MessageBox.Show("輸入錯誤");
                
            }
            else
            {
                int money = int.Parse(textBox_price.Text);  //本金
                double rate = double.Parse(textBox_rate.Text);   //年利率
                rate = rate / 100;
                int year = int.Parse(textBox_year.Text);   //年期
                int total;     //本利和
                double total_rate = CompoundInterest(money, rate, year);
                total = (int)(total_rate * money);
                string total_string = total.ToString();
                MessageBox.Show("複利金額 : "+total_string);
            }

        }
    }
}
