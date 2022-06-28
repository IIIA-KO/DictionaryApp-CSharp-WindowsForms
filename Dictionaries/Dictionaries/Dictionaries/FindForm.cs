using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionaries
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't translte a word without entering it");
                return;
            }

            foreach (MyDictionary i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    foreach (var j in i.dictionary)
                    {
                        if (j.Word.ToLower() == WordTextBox.Text.ToLower())
                        {
                            TranslationTextBox.Text = string.Join("\r\n", j.Translations);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Error: The dictionary does not contain such a word");
            return;
        }
    }
}
