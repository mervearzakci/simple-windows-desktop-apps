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
                // Validate inputs
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                    return 0;

                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                
                // Check for negative values
                if (a < 0 || b < 0)
                    return 0;

                // Optimized: Use direct calculation instead of Math.Pow for squares
                double c = Math.Sqrt(a * a + b * b);
                return c;
            }
            catch (FormatException)
            {
                // Handle invalid number format
                return 0;
            }
            catch (OverflowException)
            {
                // Handle number overflow
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
