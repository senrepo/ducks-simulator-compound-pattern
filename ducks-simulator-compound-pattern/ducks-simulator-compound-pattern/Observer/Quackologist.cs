using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*
     * (17) Lets create the IObserver interface and implement the Quackalogist
     */
    public class Quackologist : IObserver
    {
        public void Update(IQuackable duck)
        {
            Console.WriteLine($"Quackologist: {duck.ToString()} just quacked");
        }
    }
}
