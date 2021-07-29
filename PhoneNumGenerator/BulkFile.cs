using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PhoneNumGenerator
{
    partial class BulkFile : Form
    {
        public BulkFile()
        {
            InitializeComponent();

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
            comboBox1.Enabled = false;
            amountbox.ReadOnly = true;
            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You didn't select an area code.",
                    "Error"); button1.Enabled = true;
                comboBox1.Enabled = true;
                amountbox.ReadOnly = false; return;

            }
            Random r = new Random();
            int amount;
            string areaCode = comboBox1.SelectedItem.ToString();
            bool isParsable = Int32.TryParse(amountbox.Text, out amount);
            if (isParsable) { }
            else
            {
                MessageBox.Show("Cannot convert to string.\n What you can do: \n    Make sure the text box DOES NOT contain any letters.     only numbers.\n       Try again later.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                button1.Enabled = true;
                comboBox1.Enabled = true;
                amountbox.ReadOnly = false;
            }
            saveFileDialog1.ShowDialog();
            string fullPath = saveFileDialog1.FileName;
            
            string num;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                for (int i = 1; i <= amount;)
                {
                    num = makePhoneNum(areaCode, r);
                    writer.WriteLine(num);
                    Console.WriteLine("Written " + num + " to file " + fullPath);
                    i++;
                }
                MessageBox.Show("Done writing to file.",
                    "Successful operation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            button1.Enabled = true;
            comboBox1.Enabled = true;
            amountbox.ReadOnly = false;
            DialogResult result = MessageBox.Show("Do you want to open the file?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(fullPath);
            }

        }
    }
}
