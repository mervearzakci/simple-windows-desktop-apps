using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int limit = 40;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double saatlik_ucret = Convert.ToDouble(textBox1.Text);
                double haftalik_calisma_saati = Convert.ToDouble(textBox2.Text);

                double toplam_ucret = 0;
                if (haftalik_calisma_saati > limit)
                {
                    toplam_ucret = limit * saatlik_ucret;
                    toplam_ucret += (haftalik_calisma_saati - limit) * saatlik_ucret * 1.5;
                }
                else
                {
                    toplam_ucret = saatlik_ucret * haftalik_calisma_saati;
                }
                label3.Text = "Haftalık Ücret =" + toplam_ucret.ToString();
            }


            catch
            {
                MessageBox.Show("Hatalı değer girdiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Haftalık Ücret = 0";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
               
            }
        }
    }
}
