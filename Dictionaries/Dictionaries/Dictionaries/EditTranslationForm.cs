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
    public partial class EditTranslationForm : Form
    {
        public EditTranslationForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't edit translation without entering word");
                return;
            }
            if (string.IsNullOrWhiteSpace(TranslationTextBox.Text))
            {
                MessageBox.Show("Error: You can't edit translation without entering it");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewTranslationTextBox.Text))
            {
                MessageBox.Show("Error: You can't edit translation without entering a new one");
                return;
            }

            //Намудрив тут трохи
            foreach (var i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    if (i.ContainsWord(WordTextBox.Text.ToLower()))
                    {
                        for (int j = 0; j < i.dictionary.Count; j++)
                        {
                            if (i.dictionary[j].Word.ToLower() == WordTextBox.Text.ToLower())
                            {
                                if (i.dictionary[j].ContainsTranslation(TranslationTextBox.Text.ToLower()))
                                {
                                    if (!i.dictionary[j].Translations.Contains(NewTranslationTextBox.Text.ToLower()))
                                    {
                                        int where = i.dictionary[j].Translations.IndexOf(TranslationTextBox.Text.ToLower());
                                        i.dictionary[j].Translations[where] = NewTranslationTextBox.Text.ToLower();
                                        Form1.SaveDictionary(i);
                                        MessageBox.Show("The translation was succsessfully changed to new one");
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: The new translation is already contained in the dictionary");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error: There is no such a translation in dictionary");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Error: There is no such a word in dictinary");
            return;
        }
    }
}
