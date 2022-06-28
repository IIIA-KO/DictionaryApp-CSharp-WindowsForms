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
    public partial class ExportDictionaryForm : Form
    {
        public ExportDictionaryForm()
        {
            InitializeComponent();
            foreach (var i in Form1.MyDictionaries)
                DictionariesComboBox.Items.Add(i.Name);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (DictionariesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error: The dictionary is not selected");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".xml";
            saveFile.Filter = "Dictionary|*.xml";

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                try
                {
                    foreach (var i in Form1.MyDictionaries)
                    {
                        if (i.Name == DictionariesComboBox.Text)
                        {
                            Form1.ExportDictionary(i, saveFile.FileName);
                            MessageBox.Show("Dictionary was successfully exported");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else MessageBox.Show("Error: Something went wrong");
        }
    }
}
