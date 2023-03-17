using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public decimal faktoriyel(decimal x)
        {
            if (x == 1)
                return 1;
            else
                return x * faktoriyel(x - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal start = Convert.ToDecimal(textBox1.Text);
                decimal finish = Convert.ToDecimal(textBox2.Text);
                if (start > finish)
                    MessageBox.Show("Başlangıç değeri bitiş değerinden büyük olmaz");
                else
                {
                    for (decimal i = start; i <= finish; i++)
                        listBox1.Items.Add(i.ToString() + "!=" + faktoriyel(i).ToString());
                }
            }
            catch 
            {
                listBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                MessageBox.Show("Hatalı değer girdiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
