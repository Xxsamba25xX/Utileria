using System;
using System.Collections.Generic;
using System.Text;

namespace UtileriaFramework.Extensions
{
    public static class EnumerableExtensions
    {
        public static void Shuffle<T>(this IList<T> me)
        {
            Random rnd = new Random();
            for (int i = 0; i < me.Count; i++)
            {
                var auxiliar = me[i];
                var newPos = rnd.Next(i, me.Count);
                me[i] = me[newPos];
                me[newPos] = auxiliar;
            }
        }

        public static string GetString(this Array me)
        {
            StringBuilder sb = new StringBuilder();
            var max = me.LongLength;
            var lineCount = (int)Math.Pow(max, 1d / me.Rank);
            for (int i = 0; i < max; i++)
            {
                var x = i % lineCount;
                var y = i / lineCount;

                if (x == 0 && i != 0)
                    sb.AppendLine();

                sb.Append(me.GetValue(x, y) + " ");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
        public static bool TryPop<T>(this Stack<T> me, out T stackedElement)
        {
            if (me.Count > 0)
            {
                stackedElement = me.Pop();
                return true;
            }
            else
            {
                stackedElement = default;
                return false;
            }
        }

        public static LinkedListNode<T> AddFirst<T>(this LinkedList<T> me, IEnumerable<T> elements)
        {
            bool first = true;
            LinkedListNode<T> actualElementItem = null;
            LinkedListNode<T> firstElementItem = null;
            foreach (var item in elements)
            {
                if (first)
                {
                    firstElementItem = actualElementItem = me.AddFirst(item);
                }

                actualElementItem = me.AddAfter(actualElementItem, item);
            }

            return firstElementItem;
        }

        public static LinkedListNode<T> AddAfter<T>(this LinkedList<T> me, LinkedListNode<T> actual, IEnumerable<T> elements)
        {
            bool first = true;
            LinkedListNode<T> actualElementItem = null;
            LinkedListNode<T> firstElementItem = null;
            foreach (var item in elements)
            {
                if (first)
                {
                    firstElementItem = actualElementItem = me.AddAfter(actual, item);
                }

                actualElementItem = me.AddAfter(actualElementItem, item);
            }

            return firstElementItem;
        }
    }
}
