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
    public partial class DeleteWordForm : Form
    {
        public DeleteWordForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't delete word without entering it");
                return;
            }

            for (int i = 0; i < Form1.MyDictionaries.Count; i++)
            {
                if (Form1.MyDictionaries[i].ContainsWord(WordTextBox.Text.ToLower()))
                {
                    for (int j = 0; i < Form1.MyDictionaries[i].dictionary.Count; j++)
                    {
                        if (Form1.MyDictionaries[i].dictionary[j].Word.ToLower() == WordTextBox.Text.ToLower())
                        {
                            Form1.MyDictionaries[i].dictionary.Remove(Form1.MyDictionaries[i].dictionary[j]);
                            Form1.SaveDictionary(Form1.MyDictionaries[i]);
                            MessageBox.Show("The word was successfully deleted from the dictionary.");
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Success: This word is not in the dictionary anyway.");
            return;
        }
    }
}
