using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요", "[ 경고 ]");
                textBox1.Focus();
                return;
            }
            int score = int.Parse(textBox1.Text);
            string result = "";
            if(score>100 || 0 > score)
            {
                MessageBox.Show("0에서 100사이의 점수를 입력하세요", "[ 경고 ]");
                textBox1.Focus();
                return;
            }
            if (score >= 96)
            {
                result = "A+";
            }else if (score >= 91)
            {
                result = "A0";
            }else if (score >= 86)
            {
                result = "B+";
            }else if (score >= 81)
            {
                result = "B0";
            }else if (score >= 76)
            {
                result = "C+";
            }else if (score >= 71)
            {
                result = "C0";
            }else if(score >= 66)
            {
                result = "D+";
            }else if (score >= 60)
            {
                result = "D0";
            }
            else
            {
                result = "F: 재수강 당첨^^";
            }
            textBox2.Text = result;


        }
    }
}
