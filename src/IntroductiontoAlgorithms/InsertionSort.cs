using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoAlgorithms
{
    /// <summary>
    /// 插入排序算法
    /// </summary>
    public class InsertionSort
    {
        public int[] Sort(int[] input)
        {
            int[] output = new int[input.Length];

            for (int j = 0; j < input.Length; j++)
            {
                output[j] = input[j];
                int i = j - 1;
                while (i >= 0 && output[i] > input[j])
                {
                    output[i + 1] = output[i];
                    i--;
                }
                output[i + 1] = input[j];
            }

            return output;
        }
    }
}
