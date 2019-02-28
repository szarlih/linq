namespace _2_interfejsy_kolekcje
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FileLoader
    {
        private string[] _loadedWords;

        public List<string> LoadStringCollectionFromFile(string path)
        {
            List<string> wordList = new List<string>();
            LoadFile(path);
            wordList = _loadedWords.ToList();
            return wordList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        private bool LoadFile(string path)
        {
            try
            {
                _loadedWords = File.ReadAllLines(path);
                return _loadedWords.Any();
            }
            catch(FileNotFoundException ex)
            {
                //logs
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
