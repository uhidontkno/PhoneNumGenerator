using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PhoneNumGenerator
{
    partial class BulkGen : Form
    {
        public BulkGen()
        {
            InitializeComponent();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string makePhoneNum(string areaCode, Random _r)
        {

            string middle = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();
            string last4 = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();

            return areaCode + "-" + middle + "-" + last4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            comboBox1.Enabled = false;
            amountbox.ReadOnly = true;
            string n = Environment.NewLine;
            textBox2.Clear();
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You didn't select an area code.", "Error"); return;
            }
            Random r = new Random();
            int amount;
            string areaCode = comboBox1.SelectedItem.ToString();
            bool isParsable = Int32.TryParse(amountbox.Text, out amount);
            if (isParsable) { } else
            {
                MessageBox.Show("Cannot convert to string.\n What you can do: \n    Make sure the text box DOES NOT contain any letters.     only numbers.\n       Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result;
            if (amount >= 400)
            {
                result = MessageBox.Show(
                    "It seems like it might take some time to generate " + amount + " phone numbers. Do you want to choose a lower amount? ", 
                    "Question", 
                    MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { button1.Enabled = true; button2.Enabled = true; comboBox1.Enabled = true; amountbox.ReadOnly = false; return; }
                
            }
            if (amount >= 200)
            {
                result = MessageBox.Show(
                    "It seems like it might be hard to scroll through " + amount + " phone numbers. Do you want to write them to a file? ", 
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question ); 
                if (result == DialogResult.Yes) { BulkFile bulk = new BulkFile(); bulk.Show(); this.Close(); return; }

            }

            if (amount >= 6000)
            {
                result = MessageBox.Show(
                    "I cannot generate " + amount + " phone numbers. You must write them to a file so I do not freeze on you ",
                    "Question",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
                if (result == DialogResult.OK) { BulkFile bulk = new BulkFile(); bulk.Show(); this.Close(); return; }
                if (result == DialogResult.Cancel) { return; }
            }


            for (int i = 1; i <= amount;)
            {

                textBox2.Text = textBox2.Text + makePhoneNum(areaCode, r) + n;
                  i++;
            }

            button1.Enabled = true;
            button2.Enabled = true;
            comboBox1.Enabled = true;
            amountbox.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("There is nothing to copy.", "Error"); return;
            }
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Copied to the clipboard.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
