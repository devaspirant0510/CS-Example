using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myVal = textBox1.Text;
            if(myVal == "")
            {
                MessageBox.Show("입력해라", "경고");
                textBox1.Focus();
                return;
            }
            foreach(char s in myVal)
            {
                if (s != '*')
                {
                    MessageBox.Show("* 만 사용해야됩니다.", "경고");
                    return;
                }

            }
            if(0>myVal.Length || myVal.Length > 5)
            {
                MessageBox.Show("1개에서 5개사이만 가능", "경고");
                textBox1.Focus();
                return;

            }
            switch (myVal.Length)
            {
                case 5:
                    textBox2.Text = "매우 만족";
                    break;
                case 4:
                    textBox2.Text = " 만족";
                    break;
                case 3:
                    textBox2.Text = "보통";
                    break;
                case 2:
                    textBox2.Text = "불만";
                    break;
                case 1:
                    textBox2.Text = "매우 불만";
                    break;

            }

        }
    }
}
