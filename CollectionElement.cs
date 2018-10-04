/******************************************************************/
/// <copyright file="CollectionElement.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>16:06</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    using System;

    public class CollectionElement : IElement
    {
        private int _weight;

        public CollectionElement()
        {
            _weight = 0;
        }

        public CollectionElement(string name, int weight)
        {
            Name = name;
            _weight = weight;
        }

        public string Name { get; private set; }

        public int Weight
        {
            get
            {
                if(Name.ToLower().Contains("important"))
                {
                    return 1000;
                }

                return _weight;
            }

            private set
            {
                _weight = value;
            }
        }
    }
}
