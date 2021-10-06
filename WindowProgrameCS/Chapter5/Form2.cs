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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int N = int.Parse(textBox1.Text);
            int sum = 0;

            for (int i = N; i > 0; i--)
            {
                textBox2.Text += i + "+";
                sum += i;

            }
            textBox2.Text += "=" + sum;
        }
    }
}
