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
    public partial class Form2 : Form
    {
        private RadioButton[] radioBtns;
        private CheckBox[] checkBoxes;
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioBtns = new RadioButton[] { radioButton1,radioButton2,radioButton3,radioButton4,radioButton5,radioButton6};
            checkBoxes = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            String logMessage = "";
            RadioButton radioButton = getChekedRadioGroup();
            if (radioButton==null)
            {
                MessageBox.Show("연령대를 선택해주세요", "제목");
            }
            else
            {
                logMessage += "당신의 연령은 " + radioButton.Text+"\n";
            }
            logMessage = getSelectedCheckBox(logMessage);
            label1.Text = logMessage; 


        }

        private void setTextLabel1(String text)
        {
            label1.Text = text;
        }
        private RadioButton getChekedRadioGroup()
        {
            
            foreach(RadioButton el in radioBtns )
            {
                if (el.Checked)
                {
                    return el;
                }

            }
            return null;

        }
        private String getSelectedCheckBox(String msg)
        {
            int count = 0;

            foreach(CheckBox el in checkBoxes)
            {
                if (el.Checked)
                {
                    count += 1;
                    msg += el.Text+"\t";
                }
            }
            if (count == 0)
            {
                msg += "좋아하는 동물이 없습니다.\n";
            }
            else
            {
                msg += "입니다.\n총 "+count+"마리 좋아하네요";
            }
            return msg;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
