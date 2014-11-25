using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Enjoycodes.IntroductiontoAlgorithms
{
    /// <summary>
    /// 二分查找
    /// </summary>
    public class BinarySearch
    {
        public int Search(int[] input, int value)
        {
            return this.search(input, value, 0, input.Length - 1);
        }

        private int search(int[] input, int value, int low, int high)
        {
            if (low >= high)
                return -1;
            else
            {
                int middle = (high + low) / 2;

                if (value == input[middle])
                    return middle;
                else if (value < input[middle])
                    return this.search(input, value, low, middle);
                else
                    return this.search(input, value, middle, high);
            }
        }
    }
}
