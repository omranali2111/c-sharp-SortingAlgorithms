using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_SortingAlgorithms
{
    internal class MergeSort
    {
        public static List<int> MergeSortFun(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list; // Base case: already sorted if list has 0 or 1 element
            }

            int mid = list.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }

            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSortFun(left);
            right = MergeSortFun(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }
    }
}

