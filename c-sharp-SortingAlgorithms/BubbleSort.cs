using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_SortingAlgorithms
{
    internal class BubbleSort
    {
        public static List<int> BubbleSortFun(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++) // Fix: Change n-1 to n-i-1
                {
                    if (list[j] > list[j + 1])
                    {
                        // Swap the elements
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            return list;
        }
    }

}
