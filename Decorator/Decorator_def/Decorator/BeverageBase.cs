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

        public abstract int getCost();
    }
}
