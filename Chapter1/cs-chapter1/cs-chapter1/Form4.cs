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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            textBox2.Text = getStartTo5(text);
            textBox3.Text = getEndTo5(text);
            textBox4.Text = getStart3To5(text);
            textBox5.Text = getLength(text).ToString();

        }

        private String getStartTo5(String text)
        {
            return text.Substring(0, 5);
        }
        private String getEndTo5(String text)
        {
            return text.Substring(text.Length - 5, 5);

        }

        private String getStart3To5(String text)
        {
            return text.Substring(3, 2);

        }

        private int getLength(String text)
        {
            return text.Length;
        }
    }
}
