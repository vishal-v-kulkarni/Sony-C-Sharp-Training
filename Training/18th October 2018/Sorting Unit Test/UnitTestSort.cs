using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting_Test;

namespace UnitTestSort
{
    [TestClass]
    public class UnitTestSort
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 5, 4, 1, 2, 3 };
            Sort.bubble_sort(array);

            if (!UnitTestSort.IsSorted(array))
            {
                Assert.Fail();
            }

        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
