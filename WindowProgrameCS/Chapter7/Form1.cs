using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int N = int.Parse(textBox1.Text);
            while (i <= 9)
            {
                textBox2.Text += $"{N} x {i} = {N*i}\r\n";
                i += 1;
            }
            textBox2.Text += "\r\n";
            int j = 1;
            do
            {
                textBox2.Text += $"{N} x {j} = {N*j}\r\n";
                j+= 1;

            } while (j <= 9);
        }
    }
}
