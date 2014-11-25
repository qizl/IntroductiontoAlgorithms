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
    public class TestMergeSort
    {
        [TestMethod]
        public void TestSort()
        {
            int[] input = new int[10000];
            Random rad = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rad.Next(0, 10000);

            MergeSort mergeSort = new MergeSort();
            int[] output = mergeSort.Sort(input);

            Assert.IsTrue(output != null);
            Assert.IsTrue(input.Length == output.Length);
            for (int i = 0; i < output.Length; i++)
            {
                Assert.IsTrue(output.Contains(input[i]));
                Assert.IsTrue(output.Skip(i + 1).Where(m => m < output[i]).Count() == 0);
            }
        }
    }
}
