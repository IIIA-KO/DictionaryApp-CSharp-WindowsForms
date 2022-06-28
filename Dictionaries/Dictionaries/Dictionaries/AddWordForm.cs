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
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();

            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't add word without entering it");
                return;
            }
            if (string.IsNullOrWhiteSpace(TranslationTextBox.Text))
            {
                MessageBox.Show("Error: You can't add translation without translation");
                return;
            }

            foreach (MyDictionary i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    if (i.ContainsWord(WordTextBox.Text.ToLower()))
                    {
                        MessageBox.Show("Error: The dictionary already contains this word");
                        return;
                    }
                }
            }

            MyWord word = new MyWord(WordTextBox.Text.ToLower());
            word.AddTranslation(TranslationTextBox.Text.ToLower());
            foreach (MyDictionary i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    i.AddWord(word);
                    Form1.SaveDictionary(i);
                    MessageBox.Show("Word was successfully saved to dictionary");
                    return;
                }
            }
        }
    }
}
