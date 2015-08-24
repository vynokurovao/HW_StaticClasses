using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_StaticClasses_task2;

namespace HW_StaticClasses_task2_test
{
    [TestClass]
    public class MyExtension_Test
    {
        [TestMethod]
        public void SortArray_WithEmptyArray()
        {
            int[] array = new int[0] { };
            array.SortArray();
            int[] expected = new int[0] { };

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SortArray_WithNotEmptyArray()
        {
            int[] array = new int[7] { 9, 4, 2, 7, 10, 123, 5};
            array.SortArray();
            int[] expected = new int[7] { 2, 4, 5, 7, 9, 10, 123};

            CollectionAssert.AreEqual(expected, array);
        }
    }
}
