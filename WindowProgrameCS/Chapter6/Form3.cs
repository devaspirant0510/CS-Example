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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i += 3)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        textBox1.Text += $"{i + k} x {j} = {(i + k) * j}    ";
                    }
                    textBox1.AppendText("\r\n");

                }
                textBox1.AppendText("\r\n");
            }

        }
    }
}
