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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new String[] {
                "서울특별시",
                "인천광역시",
                "대구광역시",
                "부산광역시",
                "광주광역시",
                "울산광역시",
                "경기도",
                "충청도",
                "강원도",
                "경상도",
                "전라도",
                "제주도"});
            comboBox1.Text = (string)comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{comboBox1.Text} {textBox1.Text} 님, {comboBox2.Text}에 사시는군요", "[제목]");

        }
    }
}
