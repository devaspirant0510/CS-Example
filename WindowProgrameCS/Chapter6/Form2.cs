using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=2; i<=9; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    textBox1.Text += $"{i} x {j} = {i * j}\r\n";
                }
                textBox1.AppendText("\r\n");
            }
        }
    }
}
