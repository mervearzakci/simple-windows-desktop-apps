using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ekle (CheckBox chk)
        {
            int index = listBox1.Items.IndexOf(chk.Text);

            if  (chk.Checked)
            {
                if (index < 0)
                    listBox1.Items.Add(chk.Text);

            }
            else
            {
                if (index >= 0)
                    listBox1.Items.RemoveAt(index);
            }
        }

        // Optimized: Single handler for all checkboxes
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk != null)
            {
                ekle(chk);
            }
        }

        // Individual handlers for backward compatibility
        private void checkBox1_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);
        private void checkBox2_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);
        private void checkBox3_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);
        private void checkBox4_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);
        private void checkBox5_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);
        private void checkBox6_CheckedChanged(object sender, EventArgs e) => CheckBox_CheckedChanged(sender, e);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            
            string check_name = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
            // Optimized: Find and uncheck the corresponding checkbox
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
            foreach (CheckBox chk in checkBoxes)
            {
                if (chk.Text == check_name)
                {
                    chk.Checked = false;
                    break; // Exit loop once found
                }
            }
        }
    }
}
