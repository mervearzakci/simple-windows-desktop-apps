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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox5);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ekle(checkBox6);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            string check_name = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (checkBox1.Text == check_name)
                checkBox1.Checked = false;
            if (checkBox2.Text == check_name)
                checkBox2.Checked = false;
            if (checkBox3.Text == check_name)
                checkBox3.Checked = false;
            if (checkBox4.Text == check_name)
                checkBox4.Checked = false;
            if (checkBox5.Text == check_name)
                checkBox5.Checked = false;
            if (checkBox6.Text == check_name)
                checkBox6.Checked = false;
        }
    }
}
