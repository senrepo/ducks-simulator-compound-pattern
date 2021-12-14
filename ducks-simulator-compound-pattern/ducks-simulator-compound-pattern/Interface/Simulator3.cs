using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (3) We have got our Ducks, now we all need is a Simulator
     */
    public class Simulator3
    {
        public Simulator3()
        {
            
        }

        public void Simulate()
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable readheadDuck = new RedheadDuck();
            IQuackable rubberDuck = new RubberDuck();

            Console.WriteLine("Duck Simulator");

            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(rubberDuck);
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
