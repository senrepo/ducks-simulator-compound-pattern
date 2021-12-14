using System;

namespace ducks_simulator_compound_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  (1) First, we will create the Quackable interface
             *      We are starting from scratch, This time around Ducks are going to implement a Quckable interface.
             *      That way, we will know what things in the simulator can quack() -  like Mallard Ducks, Redhead Ducks, and we might evenn see the Rubber Duck sneak back in
             * 
             *  (2) Now, Ducks implement the Quackable interface
             *      MallardDuck and RedheadDuck implements teh Quackable interface
             * 
             *  (3) We have got our Ducks, now we all need is a Simulator
             *      Let us create a simulator that creates few ducks and make sure the quacks are working
             * 
             */

            Console.WriteLine("Interface Pattern");
            Simulator3 simulator3 = new Simulator3();
            simulator3.Simulate();
            Console.WriteLine("");

            /*  (4) We want to use Goose as Ducks in the Simulator
             *      After all, geese make noise, geese fly and swiim
             * 
             *  (5) We need a goose Adapter
             *      Our simulator expects to see Quackable interfaces, since geese are not quackers (they are honkers)
             *      We can use an adapter to adopt a goose to a duck
             *      
             *  (6) Now geese should be able to plaly in the simulator
             *      Create a goose object, wrap it in an adapter that implements Quackable
             *      
             */

            Console.WriteLine("Adapter Pattern");
            Simulator4 simulator4 = new Simulator4();
            simulator4.Simulate();
            Console.WriteLine("");

            /*  (7) Quackologists are facinated by all aspects of Quackable behaviour.
             *      They wanted to study the total number of quacks made by a flock of ducks.
             *      Can we add the ability to count the quacks without having to change the duck class.
             * 
             *  (8) Create a decorator that gives the ducks some new behaviour (counting behaviour) by wrapping them with a decorator object.
             *      We won't have to chagne the Duck code at all.
             *      
             *  (9) We need to update the simulator to create the decorated the ducks      
             */

            Console.WriteLine("Decorator Pattern");
            Simulator9 simulator9 = new Simulator9();
            simulator9.Simulate();
            Console.WriteLine("");

            /* (10) Its time for some quality control, We need a factory to produce the Ducks.
             *      The factory should produce a family of products that consists of different types of ducks.
             *      We are going to use the AbstractFactory pattern
             *     
             * (11) Let us create the simulator to use the factory class    
             * 
             */

            Console.WriteLine("Factory Pattern");
            Simulator11 simulator11 = new Simulator11();
            simulator9.Simulate();
            Console.WriteLine("");


            /* (12) Let us create a flock of ducks (actually a flock of Quackables)
             *      Remember composite pattern allows to treat a collection of objects same as individual objects (Menu and MenuItem)
             * 
             * (13) Create the simulator to use the composite object
             */

            Console.WriteLine("Composite Pattern");
            Simulator13 simulator13 = new Simulator13();
            simulator13.Simulate();
            Console.WriteLine("");


            /* (14) Quackologist would like to observe individual duck behaviour - Observer pattern
             *      Lets create the Observable interface
             *      
             * (15) Lets create the QuackObservable class by implementing the Observable inteface
             * 
             * (16) Implement the IObservable interface in the Flock or individual duck class
             * 
             * (17) Lets create the IObserver interface and implement the Quackalogist
             * 
             * (18) Create the simulator to use the Observer pattern
             */

            Console.WriteLine("Observer Pattern");
            Simulator18 simulator18 = new Simulator18();
            simulator18.Simulate();
            Console.WriteLine("");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();





        }
    }
}
