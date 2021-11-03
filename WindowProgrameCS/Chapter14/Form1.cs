using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14
{
    public partial class Form1 : Form
    {
        string isOperationStore = "";
        bool dotFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        bool bClear_Flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button4.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bClear_Flag == true)
            {
                textBox1.Text = "";
                bClear_Flag = false;

            }
            textBox1.AppendText(button7.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.AppendText(button10.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.AppendText(button11.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dotFlag = false;
            isOperationStore = "";
            dNum_store = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dotFlag == false)
            {
                if (textBox1.Text == "")
                {
                    textBox1.AppendText("0");
                }
                textBox1.AppendText(button12.Text);
                dotFlag = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1, 1) == ".")
                {
                    dotFlag = false;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (isOperationStore != "")
            {
                Operation();



            }
            dNum_store = double.Parse(textBox1.Text);
            isOperationStore = "×";
            bClear_Flag = true;
            dotFlag = false;

        Exit:;

        }
        double dNum_store = 0;
        public void Operation()
        {
            if (isOperationStore == "+")
            {
                textBox1.Text = (dNum_store + double.Parse(textBox1.Text)).ToString();
            }
            else if (isOperationStore == "-")
            {
                textBox1.Text = (dNum_store - double.Parse(textBox1.Text)).ToString();
            }
            else if (isOperationStore == "×")
            {
                textBox1.Text = (dNum_store * double.Parse(textBox1.Text)).ToString();

            }
            else if (isOperationStore == "÷")
            {
                textBox1.Text = (dNum_store / double.Parse(textBox1.Text)).ToString();


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (isOperationStore != "")
            {
                Operation();



            }
            dNum_store = double.Parse(textBox1.Text);
            isOperationStore = "+";
            bClear_Flag = true;
            dotFlag = false;

        Exit:;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (isOperationStore != "")
            {
                Operation();
            }
            dNum_store = double.Parse(textBox1.Text);
            isOperationStore = "-";
            bClear_Flag = true;
            dotFlag = false;

        Exit:;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                goto Exit;
            }
            if (isOperationStore != "")
            {
                Operation();
            }
            dNum_store = double.Parse(textBox1.Text);
            isOperationStore = "÷";
            bClear_Flag = true;
            dotFlag = false;

        Exit:;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Operation();
            bClear_Flag = true;
            dotFlag = false;
            isOperationStore = "";
            dNum_store = 0;
        }
    }
}
