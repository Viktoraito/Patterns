using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Add
{
    class NoAdding : IAdding
    {
        public void Add()
        {
            Console.WriteLine("Not allowed to add");
        }
    }
}
