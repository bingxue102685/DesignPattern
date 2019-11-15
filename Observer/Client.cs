using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Client
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            Observer observer1 = new ConcreteObserver();
            Observer observer2 = new ConcreteObserver();
            Observer observer3 = new ConcreteObserver();
            Observer observer4 = new ConcreteObserver();

            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);
            subject.Attach(observer4);

            subject.Invoke();

            Console.ReadKey();
        }
    }
}
