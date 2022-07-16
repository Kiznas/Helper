using System;
using NUnit.Framework;
using Helper;

namespace Library.Tests
{
    public class ArrayHelperTests
    {
        [TestCase(new[] { 10, 5, 7, 3, 4, 1, 12 }, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new[] { 12, -3, 7 }, 1)]
        [TestCase(new[] { 10, 5, 7, 3, 4, 1, 12, 99, -102 }, 8)]
        [TestCase(new[] { 4, 8, 7, 4, 15 }, 0)]
        public void GetMinIndexOfArray_WhenArrayFilled_ShouldFindFirstMinElementIndex
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetMinIndexOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0] { })]
        public void GetMinIndexOfArray_WhenArrayNullOrEmpty_ShouldThrowArgumentException
            (int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.GetMinIndexOfArray(array);
            });
        }

        [TestCase(new[] { 3, 8, 11, 9, -2, 4, 7 }, 2)]
        [TestCase(new[] { 6, 15, -5, 0, 15 }, 1)]
        [TestCase(new[] { -8, -3, -7 }, 1)]
        [TestCase(new[] { 10, 5, 7, 15, 100, 99, 12, 99, 102 }, 8)]
        public void GetMaxIndexOfArray_WhenArrayFilled_ShouldFindFirstMaxElementIndex
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetMaxIndexOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0] { })]
        public void GetMaxIndexOfArray_WhenArrayNullOrEmpty_ShouldThrowArgumentException
            (int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.GetMaxIndexOfArray(array);
            });
        }

        [TestCase(new[] { 10, 5, 7, 3, 4, 1, 12 }, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new[] { 12, -3, 7 }, -3)]
        [TestCase(new[] { 10, 5, 7, 3, 4, 1, 12, 99, -102 }, -102)]
        [TestCase(new[] { 4, 8, 7, 4, 15 }, 4)]
        public void GetMinElement_WhenArrayFilled_ShouldFindFirstMinElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetMinElementOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0] { })]
        public void GetMinElement_WhenArrayNullOrEmpty_ShouldThrowArgumentException
            (int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.GetMinElementOfArray(array);
            });
        }

        [TestCase(new[] { 3, 8, 11, 9, -2, 4, 7 }, 11)]
        [TestCase(new[] { 6, 15, -5, 0, 15 }, 15)]
        [TestCase(new[] { -8, -3, -7 }, -3)]
        [TestCase(new[] { 10, 5, 7, 15, 100, 99, 12, 99, 102 }, 102)]
        public void GetMaxElement_WhenArrayFilled_ShouldFindFirstMaxElement
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetMaxElementOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0] { })]
        public void GetMaxElement_WhenArrayNullOrEmpty_ShouldThrowArgumentException
            (int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.GetMaxElementOfArray(array);
            });
        }

        [TestCase(new[] { 12, 11, 7, 5, -10, -4, 9 }, 12)]
        [TestCase(new[] { 5, 25, -5, 0, 15 }, 25)]
        [TestCase(new[] { -8, -3, -7, -8, -11, -90 }, -101)]
        [TestCase(new int[] { }, 0)]
        public void GetSumOfOddIndexElements_WhenArrayFilled_ShouldFindSumOfOddIndexElements
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetSumOfOddNumbers(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetSumOfOddIndexElements_WhenArrayIsNull_ShouldThrowNullReferenceException
            (int[] array)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                ArrayHelper.GetSumOfOddNumbers(array);
            });
        }

        [TestCase(new[] { 5, 8, 9, 1, 0 }, new[] { 0, 1, 9, 8, 5 })]
        [TestCase(new[] { -2, 0, -11, 5, 76 }, new[] { 76, 5, -11, 0, -2 })]
        [TestCase(new[] { 0, 0, 1, 1, 0 }, new[] { 0, 1, 1, 0, 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseArray_WhenArrayFilled_ShouldReverseArrayElements
            (int[] array, int[] expected)
        {
            int[] actual = ArrayHelper.ReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void ReverseArray_WhenArrayIsNull_ShouldThrowNullReferenceException
            (int[] array)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                ArrayHelper.ReverseArray(array);
            });
        }

        [TestCase(new[] { 155, 11, 7, 5, -10, -4, 9 }, 5)]
        [TestCase(new[] { 5, 25, -5, 0, 4 }, 3)]
        [TestCase(new[] { -8, -3, -7, -8, -11, -90 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetCountOfOdds_WhenArrayFilled_ShouldFindCountOfOddElements
            (int[] array, int expected)
        {
            int actual = ArrayHelper.GetCountOfOddElements(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetCountOfOdds_WhenArrayIsNull_ShouldThrowNullReferenceException
            (int[] array)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                ArrayHelper.GetCountOfOddElements(array);
            });
        }

        [TestCase(new[] { 5, 8, 9, 1, 0 }, new[] { 1, 0, 9, 5, 8 })]
        [TestCase(new[] { -2, 0, -11, 5, 76, 12 }, new[] { 5, 76, 12, -2, 0, -11 })]
        [TestCase(new[] { 1, 0, 1, 1, 0 }, new[] { 1, 0, 1, 1, 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SwapHalfOfArray_WhenArrayFilled_ShouldSwapHalfOfArray
            (int[] array, int[] expected)
        {
            int[] actual = ArrayHelper.SwapHalfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SwapHalfOfArray_WhenArrayIsNull_ShouldThrowNullReferenceException
            (int[] array)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                ArrayHelper.SwapHalfArray(array);
            });
        }
    }
}