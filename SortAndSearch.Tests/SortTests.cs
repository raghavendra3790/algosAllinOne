using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortAndSearch.Tests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void SelectionSort()
        {
            int[] array = new []{2,1,3,4,5,0};
            Sort<int>.SelectionSort(array);
            for(int i = 0;i < 6;i++)
            {
                Assert.IsTrue(array[i] == i);
            }
        }

        [TestMethod]
        public void InsertionSort()
        {
            int[] array = new[] { 2, 1, 3, 4, 5, 0 };
            Sort<int>.InsertionSort(array);
            for (int i = 0; i < 6; i++)
            {
                Assert.IsTrue(array[i] == i);
            }
        }

        [TestMethod]
        public void MergeSortTest()
        {
            int[] array = new[] { 2, 1, 3, 4, 5, 0 };
            Sort<int>.MergeSort(array);
            for (int i = 0; i < 6; i++)
            {
                Assert.IsTrue(array[i] == i);
            }
        }
    }
}
