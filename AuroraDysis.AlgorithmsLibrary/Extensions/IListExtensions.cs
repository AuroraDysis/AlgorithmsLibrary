using System;
using System.Collections.Generic;
using System.Text;

namespace AuroraDysis.AlgorithmsLibrary.Extensions
{
    public static class IListExtensions
    {
        public static void Swap<T>(this IList<T> list, int left, int right)
        {
            var temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }

        /// <summary>
        /// 返回list[left]是否小于等于(降序则为大于等于)list[right]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="isAscending"></param>
        /// <returns>list[left]是否小于等于(降序则为大于等于)list[right]</returns>
        public static bool Compare<T>(this IList<T> list, int left, int right, bool isAscending)
            where T : IComparable<T>
        {
            int result = list[left].CompareTo(list[right]);
            return isAscending ? result <= 0 : result >= 0;
        }

        public static bool IsSorted<T>(this IList<T> list, bool isAscending)
            where T : IComparable<T>
        {
            for (int i = 1; i < list.Count; i++)
                if (!list.Compare(i - 1, i, isAscending))
                    return false;

            return true;
        }
    }
}
