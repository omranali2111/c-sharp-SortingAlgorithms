using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_SortingAlgorithms
{
    internal class SelectionSort
    {
       
        public static List<int> SelectionSortFun(List<int> list)
        {
            
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = list[smallestVal];
                list[smallestVal] = list[i];
                list[i] = tempVar;
            }
            return list;
        }
    }
}
