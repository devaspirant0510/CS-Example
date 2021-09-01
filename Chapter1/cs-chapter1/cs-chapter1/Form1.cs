using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_chapter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + "님 ㅎㅇ";
            MessageBox.Show(textBox2.Text,"제목");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
