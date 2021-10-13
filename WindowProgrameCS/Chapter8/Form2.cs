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
    public partial class Form2 : Form
    {
        TextBox[] inputArr;
        TextBox[] ouputArr;
        int[] myScores = new int[8];

        public Form2()
        {
            InitializeComponent();
            this.inputArr = new TextBox[] {textBox1,textBox2,textBox3,textBox4,textBox5,
                              textBox6,textBox7,textBox8};
            this.ouputArr = new TextBox[] {textBox9,textBox10,textBox11,textBox12,textBox13,
                                           textBox14,textBox15,textBox16};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = 0;
            foreach (TextBox item in this.inputArr)
            {
                int value;
                bool isInt = int.TryParse(item.Text, out value);
                if (isInt)
                {
                    if (value < 0 || value > 100)
                    {
                        MessageBox.Show($"0에서 100사이 숫자를 입력해주세요", "[ 경고 ]");
                        item.Focus();
                        item.Text = "";
                        return;
                    }
                    this.myScores[idx] = value;
                }
                else
                {
                    MessageBox.Show("숫자를 입력해주세요", "[ 경고 ]");
                    item.Focus();
                    item.Text = "";
                    return;
                }
                idx += 1;
            }
            idx = 0;
            foreach (int score in this.myScores)
            {
                string result = "";

                if (score >= 96)
                {
                    result = "A+";
                }
                else if (score >= 91)
                {
                    result = "A0";
                }
                else if (score >= 86)
                {
                    result = "B+";
                }
                else if (score >= 81)
                {
                    result = "B0";
                }
                else if (score >= 76)
                {
                    result = "C+";
                }
                else if (score >= 71)
                {
                    result = "C0";
                }
                else if (score >= 66)
                {
                    result = "D+";
                }
                else if (score >= 60)
                {
                    result = "D0";
                }
                else
                {
                    result = "F: 재수강 당첨^^";
                }
                this.ouputArr[idx].Text = result;
                idx += 1;

            }
        }
    }
}
