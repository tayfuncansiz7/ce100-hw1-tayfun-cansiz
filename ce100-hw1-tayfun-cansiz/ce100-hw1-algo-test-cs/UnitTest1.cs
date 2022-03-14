using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;
using System.Collections;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionSort_TestMethod1()
        {
            int[] arr = { 18, 4, 28, 12, 5, 98, 74 };
            int[] keynum = { 4, 5, 12, 18, 28, 74, 98 };

            CollectionAssert.AreEqual(Sorting.InsertionSort(arr), keynum);
        }

        [TestMethod]
        public void InsertionSort_TestMethod2()
        {
            int[] arr = { 25, 22, 19, 17, 12, 5, 1 };
            int[] keynum = { 1, 5, 12, 17, 19, 22, 25 };

            CollectionAssert.AreEqual(Sorting.InsertionSort(arr), keynum);
        }

        [TestMethod]
        public void InsertionSort_TestMethod3()
        {
            int[] arr = { 6, 33, 34, 56, 24, 9, 12 };
            int[] keynum = { 6, 9, 12, 24, 33, 34, 56 };

            CollectionAssert.AreEqual(Sorting.InsertionSort(arr), keynum);
        }

        [TestMethod]
        public void SelectionSort_TestMethod1()
        {
            int[] arr = { 2, 5, 4, 14, 9, 7, 32 };
            int[] keynum = { 2, 4, 5, 7, 9, 14, 32 };

            CollectionAssert.AreEqual(Sorting.SelectionSort(arr), keynum);
        }

        [TestMethod]
        public void SelectionSort_TestMethod2()
        {
            int[] arr = { 13, 54, 34, 65, 63, 50, 21 };
            int[] keynum = { 13, 21, 34, 50, 54, 63, 65 };

            CollectionAssert.AreEqual(Sorting.SelectionSort(arr), keynum);
        }

        [TestMethod]
        public void SelectionSort_TestMethod3()
        {
            int[] arr = { 1, 8, 3, 17, 13, 9, 54 };
            int[] keynum = { 1, 3, 8, 9, 13, 17, 54 };

            CollectionAssert.AreEqual(Sorting.SelectionSort(arr), keynum);
        }

        [TestMethod]
        public void MergeSort_TestSimple_1()
        {

            int[] Arr1 = new int[6] { 34, 21, 54, 63, 50, 13, };

            int[] Exp = new int[6] { 13, 21, 34, 50, 54, 63 };
            CollectionAssert.AreEqual(Sorting.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_2()
        {

            int[] Arr1 = new int[6] { 86, 14, 25, 75, 46, 80, };

            int[] Exp = new int[6] { 14, 25, 46, 75, 80, 86, };
            CollectionAssert.AreEqual(Sorting.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_3()
        {

            int[] Arr1 = new int[6] { 3, 74, 8, 5, 36, 54, };

            int[] Exp = new int[6] { 3, 5, 8, 36, 54, 74, };
            CollectionAssert.AreEqual(Sorting.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void Naivepower_TestMethod1()
        {
            int a = 7;
            int b = 7;
            int result = 823543;
            long c = Sorting.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void Naivepower_TestMethod2()
        {
            int a = 5;
            int b = 2;
            int result = 25;
            long c = Sorting.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void Naivepower_TestMethod3()
        {
            int a = 4;
            int b = 4;
            int result = 256;
            long c = Sorting.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_TestMethod1()
        {
            int a = 8;
            int b = 2;
            int result = 64;
            double c = Sorting.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_TestMethod2()
        {
            int a = 2;
            int b = 5;
            int result = 32;
            double c = Sorting.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_TestMethod3()
        {
            int a = 3;
            int b = 3;
            int result = 27;
            double c = Sorting.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void BinarySearchIterative_TestMethod3()
        {
            int[] array = { 1, 3, 4, 15, 16, 26, 75 };
            int index = 4;
            int result = 2;
            int c = Sorting.BinarySearchIterative(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void BinarySearchIterative_TestMethod2()
        {
            int[] array = { 45, 65, 66, 71, 74, 75, 80 };
            int index = 75;
            int result = 5;
            int c = Sorting.BinarySearchIterative(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void BinarySearchIterative_TestMethod1()
        {
            int[] array = { 34, 37, 48, 77, 90, 91, 98 };
            int index = 37;
            int result = 1;
            int c = Sorting.BinarySearchIterative(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivebinarySearch_TestMethod1()
        {
            int[] array = { 5, 6, 7, 8, 9, 10, 11 };
            int index = 7;
            int result = 2;

            int c = Sorting.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivebinarySearch_TestMethod2()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int index = 7;
            int result = 6;

            int c = Sorting.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivebinarySearch_TestMethod3()
        {
            int[] array = { 56, 57, 58, 59, 60, 61, 62 };
            int index = 56;
            int result = 0;

            int c = Sorting.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);
        }
    }
}