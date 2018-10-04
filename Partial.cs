/******************************************************************/
/// <copyright file="Partial.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>17:49</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje
{
    public partial class MySpecialCollection
    {
        public int NumberOfElements()
        {
            int counter = 0;
            while(_enumerator.MoveNext())
            {
                counter++;
            }

            _enumerator.Reset();
            return counter;
        }
    }
}
