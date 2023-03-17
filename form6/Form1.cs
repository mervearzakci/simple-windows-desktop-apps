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
        const int dis_temizleme = 180;
        const int dolgu = 220;
        const int xray = 175;

        public void hesapla()
        
        {
            int toplam = 0;
            if (checkBox1.Checked)
                toplam += dis_temizleme;
            if (checkBox2.Checked)
                toplam += dolgu;
            if (checkBox3.Checked)
                toplam += xray;
            label5.Text = "Toplam Ödenecek Tutar=" + toplam.ToString() + "TL";
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
            label2.Text = dis_temizleme.ToString() + "TL";
            label3.Text = dolgu.ToString() + "TL";
            label4.Text = xray.ToString() + "TL";
        }
    }
}
