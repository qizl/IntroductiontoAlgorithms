using Com.Enjoycodes.IntroductiontoAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Enjoycodes.IntroductiontoAlgorithmsTests
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void Test()
        {
            int[] input = new int[10000];
            for (int i = 0; i < input.Length; i++)
                input[i] = i;

            BinarySearch binarySearch = new BinarySearch();
            int value = new Random().Next(0, input.Length - 1);
            int index = binarySearch.Search(input, value);

            Assert.AreEqual(index, value);
        }
    }
}
