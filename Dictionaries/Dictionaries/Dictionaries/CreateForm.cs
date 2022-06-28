using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dictionaries
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (Form1.DictionaryExists(textBox1.Text.ToLower()))
            {
                MessageBox.Show("Error: Such a dictionary already exists");
                return;
            }

            string pattern = @"^([^-]+\-[^-]+)\b$";
            if (!Regex.IsMatch(textBox1.Text, pattern))
            {
                MessageBox.Show("The name does not match the type of required type of dictionary name. (For example: English-Russian or Russian-English)");
                return;
            }

            MyDictionary d = new MyDictionary(textBox1.Text);
            Form1.AddDictionary(d);
            MessageBox.Show("Dictionary was successfully created");
        }
    }
}
