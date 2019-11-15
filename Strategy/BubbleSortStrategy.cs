using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class BubbleSortStrategy : Strategy
    {
        public void Sort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                //找出最大值
                int minValueIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

                //交换
                int temp = list[i];
                list[i] = list[minValueIndex];
                list[minValueIndex] = temp;
            }

            Console.WriteLine("\n冒泡排序！");
            list.ForEach((value) => { Console.Write(value + " "); });
        }
    }
}
