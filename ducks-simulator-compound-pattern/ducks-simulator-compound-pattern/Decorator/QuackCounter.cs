using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (8) Create a decorator that gives the ducks some new behaviour(counting behaviour) by wrapping them with a decorator object.
     */
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfDucks = 0;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            ++numberOfDucks;
        }

        public static int GetQuacksCount()
        {
            return numberOfDucks;
        }
    }
}
