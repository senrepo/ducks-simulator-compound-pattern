using System;
using System.Collections.Generic;
using System.Text;

namespace ducks_simulator_compound_pattern
{
    /*  (5) We need a goose Adapter
     */
    public class GooseAdapter : IQuackable
    {
        Goose googse;

        public GooseAdapter(Goose geese)
        {
            this.googse = geese;
        }

        public void Quack()
        {
            googse.Honk();
        }
    }
}
