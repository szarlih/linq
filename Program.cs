/******************************************************************/
/// <copyright file="Program.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>16:03</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    using System;
    using Extensions;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            /* WritePrimesOnlyLinq(5);
             WritePrimes();


             ExtraShort();
             MySpecialCollection collection = new MySpecialCollection();

             LikeSql(collection);


             collection = new MySpecialCollection();

             var filter = collection.Where(e => e.Weight % 2 == 1);


             foreach(var e in filter)
             {
                 Console.WriteLine(string.Format("f[{0}]", e.Weight));
             }

             Console.WriteLine(collection);

             Console.WriteLine(string.Format("Is collection longer than 5 elements: {0}", collection.LongerThanFiveElements()));
             Console.ReadLine();*/

            FileLoader loader = new FileLoader();
            var wordList = loader.LoadStringCollectionFromFile("words.txt");

            FunWithLists fun = new FunWithLists();
            Console.WriteLine(fun.FindShortestWords(wordList).Count);

            Console.ReadLine();
        }

        private static void ExtraShort()
        {
            List<IElement> list = new List<IElement>();
            for (int i = 1; i < 8; i++)
            {
                list.Add(new CollectionElement(i.ToString(), i));
            }

            list.Where(e => e.Weight % 2 == 1)
                .ToList()
                .ForEach(e => Console.WriteLine("es " + e.Name));
        }

        private static void LikeSql(MySpecialCollection collection)
        {

            var anotherFilter = from e in collection where e.Weight % 2 == 1 select e;


            foreach (var e in anotherFilter)
            {
                Console.WriteLine(string.Format("s[{0}]", e.Weight));
            }
        }

        private static void WritePrimes()
        {
            Console.Write("Prime numbers: ");
            List<IElement> list = new List<IElement>();
            for (int i = 1; i < 8; i++)
            {
                list.Add(new CollectionElement(i.ToString(), i));
            }

            list.Where(e => IsPrime(e.Weight)).ToList().ForEach(e => Console.Write(string.Format("{0}, ", e.Weight)));

            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void WritePrimesOnlyLinq(int limit)
        {
            Console.Write("Prime numbers (only linq hard to understand code): ");
            var numbers = Enumerable.Range(2, (int)(limit * (Math.Log(limit) + Math.Log(System.Math.Log(limit)) - 0.5)))
                            .Where(x => Enumerable.Range(2, x - 2)
                            .All(y => x % y != 0))
                            .TakeWhile((n, index) => index <= limit);

            numbers.ToList().ForEach(e => Console.Write(string.Format("{0}, ", e)));
            Console.WriteLine();
        }
    }
}
