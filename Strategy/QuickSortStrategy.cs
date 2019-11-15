using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class QuickSortStrategy : Strategy
    {
        public void Sort(List<int> list)
        {
            list.Sort();

            Console.WriteLine("\n快速排序！");
            list.ForEach((value) => { Console.Write(value + " "); });
        }
    }
}
