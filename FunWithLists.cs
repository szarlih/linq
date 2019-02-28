namespace _2_interfejsy_kolekcje
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FunWithLists
    {
        public List<string> FindShortestWords(List<string> list)
        {
            List<string> shortest = new List<string>();
            if (list.Any())
            {
                var minLength = list.Min(x => x.Length);
                return list.Where(e => e.Length == minLength).ToList();
            }

            return shortest;
        }

        public List<string> FindWordsWithA(List<string> list)
        {
            List<string> awords = new List<string>();
            awords = list.Where(w => w.Contains('a') && !w.Contains('c')).ToList();
            return awords;
        }
    }
}
