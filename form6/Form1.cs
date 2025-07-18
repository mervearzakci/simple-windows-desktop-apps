using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Service prices as constants
        private const int DIS_TEMIZLEME_UCRET = 180;
        private const int DOLGU_UCRET = 220;
        private const int XRAY_UCRET = 175;

        public void hesapla()
        {
            int toplam = 0;
            
            // Optimized: Use array-based calculation
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3 };
            int[] prices = { DIS_TEMIZLEME_UCRET, DOLGU_UCRET, XRAY_UCRET };
            
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                    toplam += prices[i];
            }
            
            // Improved formatting
            label5.Text = $"Toplam Ödenecek Tutar = {toplam:C0}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void checkBox3_CheckedSChanged(object sender, EventArgs e)
        {
            hesapla(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Improved formatting for service prices
            label2.Text = $"{DIS_TEMIZLEME_UCRET:C0}";
            label3.Text = $"{DOLGU_UCRET:C0}";
            label4.Text = $"{XRAY_UCRET:C0}";
        }
    }
}
