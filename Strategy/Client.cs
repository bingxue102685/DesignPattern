using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Client
    {
        static void Main(string[] args)
        {
            Strategy bubbleStrategy = new BubbleSortStrategy();
            Strategy quickStrategy = new QuickSortStrategy();

            List<int> list = new List<int>();
            list.Add(12);
            list.Add(90);
            list.Add(12);
            list.Add(5);
            list.Add(2);

            Context context = new Context();

            context.SetSortStrategy(bubbleStrategy);
            context.Sort(list);

            context.SetSortStrategy(quickStrategy);
            context.Sort(list);

            Console.ReadKey();
        }
    }
}
