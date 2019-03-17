using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Packed black tea";
        }

        public override int getCost() {
            return BeverageCONST.COST_BLACKTEA;
        }
    }
}
