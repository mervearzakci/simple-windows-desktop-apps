using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form12
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
                double r = Convert.ToDouble(textBox1.Text);
                double cevre = 2 * Math.PI * r;
                double alan = Math.PI * Math.Pow(r, 2);
                label2.Text = "CEVRE=" + String.Format("{0:n2}", cevre);
                label3.Text = "ALAN=" + String.Format("{0:n2}", alan);
            }
            catch 
            {
                MessageBox.Show("Hatalı değer girildi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                label2.Text = "ÇEVRE=";
                label3.Text = "ALAN=";
                
            }
        }
    }
}
