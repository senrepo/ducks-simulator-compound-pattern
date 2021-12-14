using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (3) We have got our Ducks, now we all need is a Simulator
     *  (6) Now geese should be able to plaly in the simulator
     *  (9) We need to update the simulator to create the decorated the ducks    
     * (11) Let us create the simulator to use the factory class   
     * (13) Create the simulator to use the composite object
     * (18) Create the simulator to use the Observer pattern
     */
    public class Simulator18
    {
        AbstractDuckFactory factory = null;

        public Simulator18()
        {
            factory = new CountingDuckFactory();
        }

        public void Simulate()
        {
            IQuackable mallardDuck = factory.CreateMallardDuck();
            IQuackable readheadDuck = factory.CreateRedheadDuck();
            IQuackable rubberDuck = factory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(readheadDuck);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            IObserver quackologist = new Quackologist();
            flockOfDucks.Register(quackologist);

            Console.WriteLine("Duck Simulator with Observer pattern, Compsite pattern, Factory pattern, Decorator pattern and Adapter pattern");

            Simulate(flockOfDucks);
            Console.WriteLine($"Total number of Quacks: {QuackCounter.GetQuacksCount()}");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}