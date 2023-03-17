using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form3

{
    public partial class Form1 : Form
    {
        private object label5;

        public Form1()
        {
            InitializeComponent();
        }
        public void hesapla()
        {
            try
            {
                Decimal karton_sayisi = Convert.ToDecimal(textBox1.Text);
                Decimal urun_sayisi = Convert.ToDecimal(textBox2.Text);
                Decimal toplam_urun_sayisi = karton_sayisi * urun_sayisi;
                label3.Text = "Toplam ürün sayısı:" + toplam_urun_sayisi;
            }
            catch 
            {
                MessageBox.Show("Yanlış Değer Girildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox1.Focus();
            }        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }
    }
}
