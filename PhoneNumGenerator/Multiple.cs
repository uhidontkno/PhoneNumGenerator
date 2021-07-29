using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PhoneNumGenerator
{
    partial class Multiple : Form
    {
        public Multiple()
        {
            InitializeComponent();

        }

        public string makePhoneNum(string areaCode, Random _r)
        {

            string middle = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();
            string last4 = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();

            return areaCode + "-" + middle + "-" + last4;
        }

        private void Multiple_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var AreaCode = comboBox1.SelectedItem.ToString();
            var AreaCode2 = comboBox2.SelectedItem.ToString();
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You didn't select an area code.", "Error"); return;
            }
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("You didn't select an area code.", "Error"); return;
            }

            var n = Environment.NewLine;
            string num1 = makePhoneNum(AreaCode, r);
            string num2 = makePhoneNum(AreaCode2, r);
            textBox1.Text = num1 + n + num2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("There is nothing to copy.", "Error"); return;
            }
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copied " + textBox1.Text + " to the clipboard.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
 }

