using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*
     * (15) Lets create the QuackObservable class by implementing the Observable inteface
     */
    public class QuackObservable : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackable duck;

        public QuackObservable(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Notify()
        {
            var iterator = observers.GetEnumerator();

            while(iterator.MoveNext())
            {
                var observer = iterator.Current;
                observer.Update(duck);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
