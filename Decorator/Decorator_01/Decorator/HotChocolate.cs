using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HotChocolate : BeverageBase
    {
        public HotChocolate()
        {
            Description = "Extremely hot melted chocolate";
        }

        public override int getCost()
        {
            return BeverageCONST.COST_CHOCOLATE + base.getCost();
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
            return true;
        }
    }
}
