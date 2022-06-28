using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    [Serializable]
    public class MyDictionary
    {
        public string Name { get;  set; }
        public List<MyWord> dictionary;

        public MyDictionary()
        {
            Name = "";
            dictionary = new List<MyWord>();
        }
        public MyDictionary(string name)
        {
            Name = name;
            dictionary = new List<MyWord>();
        }

        public void AddTranslation(string word, string translation)
        {
            foreach (var item in dictionary)
            {
                if (item.Word == word)
                {
                    item.AddTranslation(translation);
                    return;
                }
                throw new Exception("Error: There is no such word in dictionary");
            }
        }

        public bool ContainsWord(string word)
        {
            foreach (var item in dictionary)
                if (item.Word == word)
                    return true;
            return false;
        }
        public bool ContainsTranslationOfWord(string word, string translation)
        {
            foreach (var item in dictionary)
            {
                if (item.Word.ToLower() == word.ToLower())
                    return item.ContainsTranslation(translation);
                else return false;
            }
            return false;
        }

        public void AddWord(MyWord word)
        {
            dictionary.Add(word);
        }
    }
}
