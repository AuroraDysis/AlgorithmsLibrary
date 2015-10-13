using Xunit;
using AuroraDysis.AlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraDysis.AlgorithmsLibrary.Extensions;
using Xunit.Abstractions;

namespace AuroraDysis.AlgorithmsLibrary.Tests
{
    public class SortingTests
    {
        private readonly ITestOutputHelper output;

        public SortingTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        private static IList<int> GetTestList()
        {
            return new List<int>() { 651, 132, 165, 46, 43, 21, 34, 654, 6, 46, 54, 321, 321, 5498, 65, 161, 6513, 21, 145, 49, 4, 16, 1, 6, 654, 65, 13, 16, 54, 654, 651, 321, 32, 16, 54987984, 5, 31, 1, 6546, 2 };
        }

        private delegate void SortDelegate<T>(IList<T> list, bool isAscending);

        private void TestSortMethod(SortDelegate<int> sort, bool isAscending)
        {
            var list = GetTestList();
            sort(list, isAscending);
            output.WriteLine(string.Join(",", list));
            Assert.True(list.IsSorted(isAscending));
        }

        [Fact()]
        public void BubbleSortTest()
        {
            TestSortMethod(Sorting.BubbleSort, true);
            TestSortMethod(Sorting.BubbleSort, false);
        }

        [Fact()]
        public void SelectionSortTest()
        {
            TestSortMethod(Sorting.SelectionSort, true);
            TestSortMethod(Sorting.SelectionSort, false);
        }

        [Fact()]
        public void InsertionSortTest()
        {
            TestSortMethod(Sorting.InsertionSort, true);
            TestSortMethod(Sorting.InsertionSort, false);
        }
    }
}