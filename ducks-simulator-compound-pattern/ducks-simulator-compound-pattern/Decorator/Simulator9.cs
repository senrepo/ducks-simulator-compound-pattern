using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (3) We have got our Ducks, now we all need is a Simulator
     *  (6) Now geese should be able to plaly in the simulator
     *  (9) We need to update the simulator to create the decorated the ducks        
     */
    public class Simulator9
    {
        public Simulator9()
        {

        }

        public void Simulate()
        {
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable readheadDuck = new QuackCounter (new RedheadDuck());
            IQuackable rubberDuck = new QuackCounter (new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator with Goose Adapter and Quack Counter Decorator");

            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine($"Total number of Quacks: {QuackCounter.GetQuacksCount()}");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}