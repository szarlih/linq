using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_interfejsy_kolekcje
{
    public class Translator
    {
        Dictionary<string, string> dictionary;

        public Translator()
        {
            LoadWords();
        }

        public string Translate(string word)
        {
            var known = dictionary.FirstOrDefault(x => x.Key.Equals(word.ToLower()) || x.Value.Equals(word.ToLower()));
            return known.Key.Equals(word) ? known.Value : known.Key;
        }

        public string TranslateNoFullLinq(string word)
        {
            string foundedWord;
            var result = dictionary.TryGetValue(word, out foundedWord);
            if (result)
            {
                return foundedWord;
            }

            foundedWord = dictionary.FirstOrDefault(x => x.Value.Equals(word)).Key;

            return foundedWord;
        }

        private void LoadWords()
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("cat", "kot");
            dictionary.Add("dog", "pies");
            dictionary.Add("blue", "niebieski");
        }
    }
}
