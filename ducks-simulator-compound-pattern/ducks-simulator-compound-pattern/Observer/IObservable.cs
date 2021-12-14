using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*
     * (14) Quackologist would like to observe individual duck behaviour - Observer pattern
     */
    public interface IObservable
    {
        void Register(IObserver observer);
        void Notify();
    }
}
