/******************************************************************/
/// <copyright file="MyExtensions.cs" company="Sharpro">
/// Copyright (c) 2018 All Rights Reserved
/// </copyright>
/// <author>Jarosław Mielewski</author>
/// <date>17:41</date>
/******************************************************************/

namespace _2_interfejsy_kolekcje.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class MyExtensions
    {
        public static bool LongerThanFiveElements(this MySpecialCollection collection)
        {
            return collection.NumberOfElements() > 5;
        }
    }
}
