using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (3) We have got our Ducks, now we all need is a Simulator
     *  (6) Now geese should be able to plaly in the simulator
     */
    public class Simulator4
    {
        public Simulator4()
        {

        }

        public void Simulate()
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable readheadDuck = new RedheadDuck();
            IQuackable rubberDuck = new RubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());


            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
