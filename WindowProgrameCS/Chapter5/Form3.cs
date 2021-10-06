using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            int N = int.Parse(textBox1.Text);
            int sum1 = 0, sum2 = 0;
            for (int i=1; i<N+1; i++)
            {
                if (i % 2 == 1)
                {
                    textBox2.Text += i+" + ";
                    sum1 += i;
                }
                else
                {
                    textBox3.Text += i+" + ";
                    sum2 += i;
                }

            }
            textBox2.AppendText("=" + sum1);
            textBox3.AppendText("=" + sum2);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
