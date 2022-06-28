using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dictionaries
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string res = "Word: ";

            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }
            if (string.IsNullOrWhiteSpace(WordTextBox.Text))
            {
                MessageBox.Show("Error: You can't export word without entering it");
                return;
            }

            bool flag_found = false;
            foreach (MyDictionary i in Form1.MyDictionaries)
            {
                if (i.Name == DictionariesComboBox.Text)
                {
                    for (int j = 0; j < i.dictionary.Count; j++)
                    {
                        if (i.dictionary[j].Word.ToLower() == WordTextBox.Text.ToLower())
                        {
                            res += i.dictionary[j].Word + "\nTranslations:\n";
                            res += String.Join("\n", i.dictionary[j].Translations);
                            flag_found = true;
                        }
                    }
                }
            }
            if (!flag_found)
            {
                MessageBox.Show("Error: The dictionary does not contain such a word");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Translation|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(res);
                    sw.Close();
                }
            }
            else MessageBox.Show("Error: Something went wrong");
        }
    }
}
