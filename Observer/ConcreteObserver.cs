using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        public void Update(object obj)
        {
            Console.WriteLine("Observer Recived:" + obj);
        }
    }
}
