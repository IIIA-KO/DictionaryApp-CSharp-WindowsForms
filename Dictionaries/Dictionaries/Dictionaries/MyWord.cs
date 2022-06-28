using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    [Serializable]
    public class MyWord
    {
        public string Word { get; set; }
        public List<string> Translations { get; private set; } = new List<string>();

        public MyWord()
        {
            Word = "";
        }
        public MyWord(string word)
        {
            Word = word;
        }

        public void AddTranslation(string translation)
        {
            Translations.Add(translation);
        }

        public bool ContainsTranslation(string translation)
        {
            return Translations.Contains(translation);
        }
    }
}
