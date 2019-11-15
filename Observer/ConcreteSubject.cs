using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class ConcreteSubject : Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(object obj)
        {
            observers.ForEach((observer) => { observer.Update(obj); });
        }

        public void Invoke()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Subject:" + i);
                NotifyObservers(i);
            }
        }
    }
}
