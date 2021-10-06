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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.Text != "")
            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
            else
            {
                MessageBox.Show("아이템을 선택해라", "경고");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Text != "")
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.Remove(listBox2.Text);

            }
            else
            {
                MessageBox.Show("아이템을 선택해라", "경고");
            }
        }
    }
}
