using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void ekle(string str)
        {
            if (textBox1.Text.Length >= 4)
                textBox1.Clear();

            textBox1.Text += str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ekle("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ekle("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ekle("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ekle("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle("6");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ekle("7");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ekle("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ekle("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ekle("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4)
            {
                int kod = Convert.ToInt16(textBox1.Text);
                switch (kod)
                {
                    case 1005:
                    case 1006:

                        listBox1.Items.Add(DateTime.Now.ToString() + "Güvenlik");
                        break;

                    case 1007:
                    case 1008:

                        listBox1.Items.Add(DateTime.Now.ToString() + "Akademisyen");
                        break;

                    case 1009:

                        listBox1.Items.Add(DateTime.Now.ToString() + "Öğrenci");
                        break;

                    default:
                        listBox1.Items.Add(DateTime.Now.ToString() + "Erişim Engellendi");
                        break;
                }
            }
        }
    }
}
