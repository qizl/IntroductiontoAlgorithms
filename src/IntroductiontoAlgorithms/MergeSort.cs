using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Enjoycodes.IntroductiontoAlgorithms
{
    /// <summary>
    /// 合并排序算法
    /// </summary>
    public class MergeSort
    {
        public int[] Sort(int[] input)
        {
            return this.sort(ref input, 0, input.Length - 1);
        }

        private int[] sort(ref int[] input, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;

                this.sort(ref input, p, q);
                this.sort(ref input, q + 1, r);

                this.merge(ref input, p, q, r);
            }

            return input;
        }

        private int[] merge(ref int[] input, int p, int q, int r)
        {
            int[] left = new int[q - p + 1];
            Array.Copy(input, p, left, 0, left.Length);
            int[] right = new int[r - q];
            Array.Copy(input, q + 1, right, 0, right.Length);

            for (int i = 0, j = 0, k = p; k <= r; k++)
            {
                if (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                        input[k] = left[i++];
                    else
                        input[k] = right[j++];
                }
                else
                {
                    input[k] = i >= left.Length ? right[j++] : left[i++];
                }
            }

            return input;
        }
    }
}
