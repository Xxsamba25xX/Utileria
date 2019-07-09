using System;
using System.Collections.Generic;
using System.Text;

namespace Utileria.ObjectUtils
{
    public static class CharUtils
    {
        public static IEnumerable<char> GetRange(int minIndex, int maxIndex = -1)
        {
            if (maxIndex < 0) maxIndex = 256;
            if (maxIndex < minIndex) throw new ArgumentException("minIndex es mayor que el máximo, que te está pasando?");

            List<char> chars = new List<char>();
            for (int i = minIndex; i < maxIndex; i++)
            {
                chars.Add((char)i);
            }

            return chars;
        }
    }
}
