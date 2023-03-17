using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Trim() == "") return;
                if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
                    MessageBox.Show("Listede eklenmiş durumda");
                else
                    listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            DialogResult d = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
  }

