/******************************************************************/
/// <copyright file="ElementEnumerator.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>16:09</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ElementEnumerator : IEnumerator<IElement>
    {
        private List<IElement> _elements;
        private int _position;

        public IElement Current
        {
            get
            {
                try
                {
                    return _elements[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => _elements[_position];

        public ElementEnumerator()
        {
            _position = -1;
            _elements = new List<IElement>();

            for (int i = 1; i < 8; i++)
            {
                _elements.Add(new CollectionElement(i.ToString(), i));
            }
        }

        public void Dispose()
        {
            _position = -1;
        }

        public bool MoveNext()
        {
            return (++_position < _elements.Count);
        }

        public void Reset()
        {
            _position = -1;
        }

        public bool MovePrevious()
        {
            return (--_position > -1);
        }

        public void Insert(IElement element)
        {
            _elements[_position + 1] = element;
        }
    }
}
