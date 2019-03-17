using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Cappucino : BeverageBase
    {
        public Cappucino()
        {
            Description = "Delicious cappucino";
        }

        public override int getCost()
        {
            return BeverageCONST.COST_CAPPUCINO;
        }
    }
}
