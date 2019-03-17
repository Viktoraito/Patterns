using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = "Overpriced espresso";
        }

        public override int getCost()
        {
            return BeverageCONST.COST_ESPRESSO;
        }
    }
}
