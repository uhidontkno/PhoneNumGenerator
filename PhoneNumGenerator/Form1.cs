using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhoneNumGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                    {
                MessageBox.Show("You didn't select an area code.", "Error"); return;
            } 
            Random r = new Random();
            var AreaCode = comboBox1.SelectedItem.ToString();
            


            textBox1.Text = makePhoneNum(AreaCode, r);


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        public string makePhoneNum(string areaCode, Random _r)
        {
            
            string middle = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();
            string last4 = _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString() + _r.Next(0, 9).ToString();

            return areaCode + "-" + middle + "-" + last4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Extras extraform = new Extras();
                extraform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
