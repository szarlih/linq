/******************************************************************/
/// <copyright file="MySpecialCollection.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>16:08</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public partial class MySpecialCollection : IEnumerable<IElement>
    {
        private IEnumerator _enumerator;

        public MySpecialCollection()
        {
            _enumerator = new ElementEnumerator();
        }

        public IEnumerator<IElement> GetEnumerator()
        {
            return new ElementEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _enumerator;
        }

        public override string ToString()
        {
            StringBuilder collectionPreview = new StringBuilder();
            ElementEnumerator enumerator = GetEnumerator() as ElementEnumerator;
            if(!enumerator.MoveNext())
            {
                return "SpecialCollection.Empty";
            }

            enumerator.MovePrevious();

            while(enumerator.MoveNext())
            {
                collectionPreview.AppendFormat("[{0}]", enumerator.Current.Name);
            }

            return collectionPreview.ToString();
        }
    }
}
