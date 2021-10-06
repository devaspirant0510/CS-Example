using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3
{
    public partial class Form1 : Form
    {
        CheckBox[] checkBoxArray;
        RadioButton[] radioButtonArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButtonArray = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
            this.checkBoxArray = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach(RadioButton item in this.radioButtonArray){
                if (item.Checked)
                {
                    label1.Text += "당신의 연령대는 "+item.Text;
                }
            }
            label1.Text += "\n당신이 선택한 항목은\n";
            foreach(CheckBox item in this.checkBoxArray)
            {
                if (item.Checked)
                {
                    label1.Text +=item.Text+"\n";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
