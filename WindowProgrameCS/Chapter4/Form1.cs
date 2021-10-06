using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4
{
    public partial class Form1 : Form
    {
        int num1, num2;
        double dNum1, dNum2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingTextBox("+");
            textBox3.Text = (num1 + num2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingTextBox("-");
            textBox3.Text = (num1 - num2).ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            settingTextBox("/");
            textBox3.Text = (dNum1 / dNum2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settingTextBox("*");
            textBox3.Text = (num1 * num2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            settingTextBox("^");
            textBox3.Text = Math.Pow(num1, num2).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            settingTextBox("%");
            textBox3.Text = (num1 % num2).ToString();

        }


        private void settingTextBox(String sign)
        {
            checkBlank(textBox1);
            checkBlank(textBox2);
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            dNum1 = double.Parse(textBox1.Text);
            dNum2 = double.Parse(textBox2.Text);
            label4.Text = sign;
        }

        private void checkBlank(TextBox tbx)
        {
            if (tbx.Text.Length == 0)
            {
                MessageBox.Show(tbx.Name + "빈칸을 입력해주세요", "[경고]");
                return;
            }
        }
    }
}
