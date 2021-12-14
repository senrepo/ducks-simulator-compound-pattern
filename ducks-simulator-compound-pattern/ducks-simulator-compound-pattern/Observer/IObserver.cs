using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*
     * (17) Lets create the IObserver interface and implement the Quackalogist
     */

    public interface IObserver
    {
        void Update(IQuackable duck);
    }
}
