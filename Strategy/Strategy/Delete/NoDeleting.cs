using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Delete
{
    class NoDeleting : IDeleting
    {
        public void Delete()
        {
            Console.WriteLine("Not allowed to delete");
        }
    }
}
