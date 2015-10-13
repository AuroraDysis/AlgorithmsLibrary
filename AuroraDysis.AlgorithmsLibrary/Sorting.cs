using AuroraDysis.AlgorithmsLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraDysis.AlgorithmsLibrary
{
    public static class Sorting
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="order"></param>
        public static void BubbleSort<T>(IList<T> list, bool isAscending = true)
            where T : IComparable<T>
        {
            int count = list.Count;

            for (bool sorted = false; sorted = !sorted; count--)
                for (int i = 1; i < count; i++)
                {
                    if (!list.Compare(i - 1, i, isAscending))
                    {
                        list.Swap(i - 1, i);
                        sorted = false;
                    }
                }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void SelectionSort<T>(IList<T> list, bool isAscending = true)
            where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                int minOrMax = i;

                for (int j = i; j < list.Count; j++)
                    if (!list.Compare(minOrMax, j, isAscending))
                        minOrMax = j;

                if (i != minOrMax)
                    list.Swap(i, minOrMax);
            }
        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="isAscending"></param>
        public static void InsertionSort<T>(IList<T> list, bool isAscending = true)
            where T : IComparable<T>
        {
            for (int i = 1; i < list.Count; i++)
                for (int j = i; j > 0 && !list.Compare(j - 1, j, isAscending); j--)
                    list.Swap(j, j - 1);
        }
    }
}
