using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int not = Convert.ToInt16(textBox1.Text);
                if (not >= 0 && not <= 100)
                {
                    listBox1.Items.Add(not.ToString());
                    if (listBox1.Items.Count >= 100)
                    {
                        button1.Enabled = false;
                        button3.Enabled = true;

                    }

                }
               else
                {
                    MessageBox.Show("0-100 aralığında bir değer giriniz", "HATA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox1.Focus();

                }
            }
            catch 
            {
                MessageBox.Show("Hatalı değer girildi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            label4.Text = "";
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                toplam += Convert.ToDecimal(listBox1.Items[i]);
            decimal ortalama = toplam / listBox1.Items.Count;
            Lablel4.Text = String.Format("{0:n1}", ortalama);
        }
    }
}
