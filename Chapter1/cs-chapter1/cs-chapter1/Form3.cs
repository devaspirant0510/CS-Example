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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("파이썬");
            listBox1.Items.Add("자바");
            listBox1.Items.Add("자바스크립트");
            listBox1.Items.Add("고");
            listBox1.Items.Add("러스트");
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem(textBox1.Text);

        
        }
        private void addItem(String item)
        {
            if (item == "")
            {
                MessageBox.Show("입력해주세요", "경고");
            }
            else
            {
                listBox1.Items.Add(item);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
        private void removeItem(int index)
        {
            listBox1.Items.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("아이템을 선택해주세요", "경고");

            }
            else
            {
            removeItem(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
