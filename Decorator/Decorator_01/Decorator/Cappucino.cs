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
            return BeverageCONST.COST_CAPPUCINO + base.getCost();
        }

        public override bool hasMilk()
        {
            return true;
        }
        public override bool hasShugar()
        {
            return true;
        }
        public override bool hasChocolate()
        {
            return false;
        }
    }
}
