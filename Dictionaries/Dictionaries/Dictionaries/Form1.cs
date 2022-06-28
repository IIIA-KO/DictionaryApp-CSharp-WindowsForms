using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Dictionaries
{
    public partial class Form1 : Form
    {
        public static List<MyDictionary> MyDictionaries;
        public Form1()
        {
            InitializeComponent();

            MyDictionaries = new List<MyDictionary>();
        }

        private void CreateDictionaryButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();

            createForm.MdiParent = this;
            createForm.Dock = DockStyle.Fill;
            createForm.Show();
            this.Show();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //LoadForm loadForm = new LoadForm();

            //loadForm.MdiParent = this;
            //loadForm.Dock = DockStyle.Fill;
            //loadForm.Show();
            //this.Show();
            string path = @"";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                path = openFileDialog1.FileName;

            try
            {
                Form1.LoadDictionary(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            AddWordForm addForm = new AddWordForm();

            addForm.MdiParent = this;
            addForm.Dock = DockStyle.Fill;
            addForm.Show();
            this.Show();

        }
        private void AddTranslationButton_Click(object sender, EventArgs e)
        {
            AddTranslationForm addTranslationForm = new AddTranslationForm();

            addTranslationForm.MdiParent = this;
            addTranslationForm.Dock = DockStyle.Fill;
            addTranslationForm.Show();
            this.Show();

        }

        private void DeleteWordButton_Click(object sender, EventArgs e)
        {
            DeleteWordForm deleteWordForm = new DeleteWordForm();

            deleteWordForm.MdiParent = this;
            deleteWordForm.Dock = DockStyle.Fill;
            deleteWordForm.Show();
            this.Show();

        }
        private void DeleteTranslationButton_Click(object sender, EventArgs e)
        {
            DeleteTranslationForm deleteTranslationForm = new DeleteTranslationForm();

            deleteTranslationForm.MdiParent = this;
            deleteTranslationForm.Dock = DockStyle.Fill;
            deleteTranslationForm.Show();
            this.Show();


        }

        private void EditWordButton_Click(object sender, EventArgs e)
        {
            EditWordForm editWordForm = new EditWordForm();

            editWordForm.MdiParent = this;
            editWordForm.Dock = DockStyle.Fill;
            editWordForm.Show();
            this.Show();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditTranslationForm editTranslationForm = new EditTranslationForm();

            editTranslationForm.MdiParent = this;
            editTranslationForm.Dock = DockStyle.Fill;
            editTranslationForm.Show();
            this.Show();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();

            findForm.MdiParent = this;
            findForm.Dock = DockStyle.Fill;
            findForm.Show();
            this.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();

            exportForm.MdiParent = this;
            exportForm.Dock = DockStyle.Fill;
            exportForm.Show();
            this.Show();
        }

        private void ExportDictButton_Click(object sender, EventArgs e)
        {
            ExportDictionaryForm exportDictionaryForm = new ExportDictionaryForm();

            exportDictionaryForm.MdiParent = this;
            exportDictionaryForm.Dock = DockStyle.Fill;
            exportDictionaryForm.Show();
            this.Show();
        }

        private static void LoadDictionary(string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(MyDictionary));
            using (var reader = new StreamReader(path))
            {
                var myDict = xmlSerializer.Deserialize(reader);
                if (myDict != null && myDict is MyDictionary m)
                {
                    MyDictionaries.Add(m);
                    MessageBox.Show("Succsess: Dictionary was loaded from file");
                }
            }

        }
        public static void SaveDictionary(MyDictionary d)
        {
            string DictFileName = "" + d.Name + ".xml";
            if (File.Exists(DictFileName)) File.Delete(DictFileName);

            var xmlSerializer = new XmlSerializer(typeof(MyDictionary));
            using (var writer = new StreamWriter(DictFileName))
            {
                xmlSerializer.Serialize(writer, d);
            }
        }

        public static void ExportDictionary(MyDictionary d, string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(MyDictionary));
            using (var writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, d);
            }
        }

        public static void AddDictionary(MyDictionary d)
        {
            MyDictionaries.Add(d);
            SaveDictionary(d);
        }
        public static bool DictionaryExists(string dictionaryName)
        {
            foreach (var i in MyDictionaries)
                if (dictionaryName == i.Name.ToLower())
                    return true;
            return false;
        }
    }
}