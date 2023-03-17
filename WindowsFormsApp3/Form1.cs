using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Hipotenus_Hesapla()
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                 return c;
            }
            catch 
            {
               // textBox1.Text = "0";
               // textBox2.Text = "0";
               return 0;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Hipotenüs=" + String.Format("{0:n2}", Hipotenus_Hesapla());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Hipotenüs=" + String.Format("{0:n2}", Hipotenus_Hesapla());
        }
    }
}
