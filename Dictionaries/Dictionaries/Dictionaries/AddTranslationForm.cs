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
    public partial class AddTranslationForm : Form
    {
        public AddTranslationForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string translation = TranslationTextBox.Text.ToLower();

            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't add translation without entering it");
                return;
            }
            if (string.IsNullOrWhiteSpace(TranslationTextBox.Text))
            {
                MessageBox.Show("Error: You can't add translation without translation");
                return;
            }

            foreach (var i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    if (i.ContainsWord(WordTextBox.Text.ToLower()))
                    {
                        foreach (var j in i.dictionary)
                        {
                            if (j.Word.ToLower() == WordTextBox.Text.ToLower())
                            {
                                if (j.ContainsTranslation(translation))
                                {
                                    MessageBox.Show("Error: The dictionary already contains this translation");
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: The dictionary does not contain such a word");
                        return;
                    }
                }
            }

            foreach (MyDictionary i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    foreach (var j in i.dictionary)
                    {
                        if (j.Word.ToLower() == WordTextBox.Text.ToLower())
                        {
                            j.AddTranslation(translation.ToLower());
                            Form1.SaveDictionary(i);
                            MessageBox.Show("Translation was successfully saved to dictionary");
                            return;
                        }
                    }
                }
            }
        }
    }
}
