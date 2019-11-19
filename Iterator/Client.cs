using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Client
    {
        static void Main(string[] args)
        {
            //客户端无需关心容器中的数据结构和实现方式，容器中不用暴露细节
            //元素的遍历与实现分离
            ConcreateAggragate aggregate = new ConcreateAggragate();
            aggregate.AddItem("Item1");
            aggregate.AddItem("Item2");
            aggregate.AddItem("Item3");

            IMyIterator myIterator = aggregate.GetIterator();

            while (myIterator.HasNext())
            {
                Console.WriteLine(myIterator.Next());
            }
            Console.ReadKey();
        }
    }
}
