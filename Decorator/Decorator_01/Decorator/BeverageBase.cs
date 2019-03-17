using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BeverageBase
    {
        protected string Description = "";

        public string getDescription() {
            return Description;   
        }

        public virtual int getCost()
        {
            int cost = 0;

            if (hasMilk())
                cost += BeverageCONST.PRICEMILK;

            if (hasShugar())
                cost += BeverageCONST.PRICESHUGAR;

            if (hasChocolate())
                cost += BeverageCONST.PRICECHOCOLATE;
            return cost;
        }

        public abstract bool hasMilk();
        public abstract bool hasShugar();
        public abstract bool hasChocolate();

    }
}
