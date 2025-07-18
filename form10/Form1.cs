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
        // Constants for access codes
        private const int SECURITY_CODE_1 = 1005;
        private const int SECURITY_CODE_2 = 1006;
        private const int ACADEMIC_CODE_1 = 1007;
        private const int ACADEMIC_CODE_2 = 1008;
        private const int STUDENT_CODE = 1009;
        private const int MAX_CODE_LENGTH = 4;

        public Form1()
        {
            InitializeComponent();
        }
        public void ekle(string str)
        {
            if (textBox1.Text.Length >= MAX_CODE_LENGTH)
                textBox1.Clear();

            textBox1.Text += str;
        }

        // Optimized: Single handler for all number buttons
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                ekle(btn.Text);
            }
        }

        // Individual handlers for backward compatibility
        private void button1_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button12_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == MAX_CODE_LENGTH)
            {
                try
                {
                    int kod = Convert.ToInt32(textBox1.Text);
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string accessResult = GetAccessLevel(kod);
                    
                    listBox1.Items.Add($"{timestamp} - {accessResult}");
                    textBox1.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Geçersiz kod formatı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show($"Kod {MAX_CODE_LENGTH} haneli olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetAccessLevel(int kod)
        {
            switch (kod)
            {
                case SECURITY_CODE_1:
                case SECURITY_CODE_2:
                    return "Güvenlik Personeli";

                case ACADEMIC_CODE_1:
                case ACADEMIC_CODE_2:
                    return "Akademisyen";

                case STUDENT_CODE:
                    return "Öğrenci";

                default:
                    return "Erişim Engellendi";
            }
        }
    }
}
