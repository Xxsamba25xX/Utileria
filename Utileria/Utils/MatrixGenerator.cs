using System;
using System.Collections.Generic;
using System.Text;
using Utileria.Extensions;
using Utileria.ObjectUtils;

namespace Utileria.Utils
{
    public static class MatrixGenerator
    {

        public static string Generate(int width, int lenght, CharType type, bool? canRepeat = null)
        {
            List<char> chars = new List<char>();
            if (type.HasFlag(CharType.Letters))
            {
                chars.AddRange(CharUtils.GetRange(65, 91));
            }
            if (type.HasFlag(CharType.Numbers))
            {
                chars.AddRange(CharUtils.GetRange(48, 58));
            }
            if (type.HasFlag(CharType.Symbols))
            {
                chars.AddRange(CharUtils.GetRange(33, 48));
                chars.AddRange(CharUtils.GetRange(58, 65));
                chars.AddRange(CharUtils.GetRange(91, 97));
                chars.AddRange(CharUtils.GetRange(123, 127));
                chars.AddRange(CharUtils.GetRange(128, 141));
                chars.AddRange(CharUtils.GetRange(145, 157));
                chars.AddRange(CharUtils.GetRange(161, 173));
                chars.AddRange(CharUtils.GetRange(174, 192));
            }
            return Generate(width, lenght, chars.ToArray(), canRepeat);
        }

        public  static string Generate(int widht, int lenght, char[] charsToUse, bool? canRepeat = null)
        {
            if (canRepeat == null)
            {
                if (widht * lenght <= charsToUse.Length)
                    canRepeat = false;
                else
                    canRepeat = true;
            }
            else
            {
                if (canRepeat == false && widht * lenght >= charsToUse.Length)
                    throw new ArgumentException("tamaño de la matriz mas grande que los caracteres a usar, pero no se puede repetir?? que carajos te pasa?");
            }

            charsToUse.Shuffle();
            var index = 0;

            var matrix = new string[widht, lenght];
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int x = 0; x < matrix.GetLength(0); x++)
                {
                    matrix[x, y] = charsToUse[index].ToString();
                    index++;
                    if (charsToUse.Length >= index)
                    {
                        index = 0;
                        charsToUse.Shuffle();
                    }
                }
            }

            string board = matrix.GetString();
            return board;
        }

       
    }

    [Flags]
    public enum CharType
    {
        Numbers = 1,
        Letters = 2,
        Spaces = 4,
        Symbols = 8,
    }
}
