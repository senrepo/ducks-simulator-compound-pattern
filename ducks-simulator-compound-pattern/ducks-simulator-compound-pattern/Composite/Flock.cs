using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*
     * (12) Let us create a flock of ducks (actually a flock of Quackables)
     * 
     * (16) Implement the IObservable interface in the Flock or individual duck class - Observer pattern
     */
    public class Flock : IQuackable, IObservable
    {
        List<IQuackable> quackers = new List<IQuackable>();
        IObservable observable;

        public Flock()
        {
            observable = new QuackObservable(this);
        }

        public void Add(IQuackable duck)
        {
            quackers.Add(duck);
        }

        public void Notify()
        {
            observable.Notify();
        }

        public void Quack()
        {
            var iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable duck = iterator.Current;
                duck.Quack();
                Notify();
            }
        }

        public void Register(IObserver observer)
        {
            observable.Register(observer);
        }
    }
}
