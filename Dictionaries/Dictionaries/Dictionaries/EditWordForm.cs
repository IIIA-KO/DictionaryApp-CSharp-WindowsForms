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
    public partial class EditWordForm : Form
    {
        public EditWordForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Error: You can't edit word without entering it");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewWordTextBox.Text))
            {
                MessageBox.Show("Error: You can't edit word without entering a new one");
                return;
            }

            foreach (var i in Form1.MyDictionaries)
            {
                if (i.ContainsWord(NewWordTextBox.Text.ToLower()))
                {
                    MessageBox.Show("Error: The new word is already contained in the dictionary");
                    return;
                }
            }
            for (int i = 0; i < Form1.MyDictionaries.Count; i++)
            {
                if (Form1.MyDictionaries[i].ContainsWord(WordTextBox.Text.ToLower()))
                {
                    for (int j = 0; j < Form1.MyDictionaries[i].dictionary.Count; j++)
                    {
                        if (Form1.MyDictionaries[i].dictionary[j].Word.ToLower() == WordTextBox.Text.ToLower())
                        {
                            Form1.MyDictionaries[i].dictionary[j].Word = NewWordTextBox.Text;
                            Form1.SaveDictionary(Form1.MyDictionaries[i]);
                            MessageBox.Show("The word was succsessfully changed to new one");
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Error: There is no such a word in dictinary");
            return;
        }
    }
}