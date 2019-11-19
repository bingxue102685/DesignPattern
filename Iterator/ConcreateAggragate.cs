using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ConcreateAggragate : IAggregate
    {
        //容器类，存放数据
        private List<string> list = new List<string>();

        public void AddItem(string item)
        {
            list.Add(item);
        }

        public bool RemoveItem(string item)
        {
            return list.Remove(item);
        }
        
        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public string this[int index]
        {
            get
            {
                return list[index];
            }
            
            set
            {
                list.Insert(index, value);
            }
        }

        //获取对应该容器的迭代器
        public IMyIterator GetIterator()
        {
            return new ConcreteMyIterator(this);
        }
    }
}
