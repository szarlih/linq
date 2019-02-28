namespace _2_interfejsy_kolekcje
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ListFromFileLoader
    {
        private string[] stringArray;

        public List<string> Load(string path)
        {
            var stringList = new List<string>();
            if (LoadFromFile(path) && stringArray.Any())
            {
                foreach (string line in stringArray)
                {
                    stringList.Add(line);
                }
            }

            return stringList;
        }

        private bool LoadFromFile(string path)
        {
            bool result = true;
            try
            {
                stringArray = File.ReadAllLines(path);
            }
            catch(ArgumentNullException ex)
            {
                result = false;
            }
            catch(FileNotFoundException ex)
            {
                result = false;
            }
            catch(PathTooLongException ex)
            {
                result = false;
            }

            return result;
        }
    }
}
