using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Delete
{
    class Deleting : IDeleting
    {
        public void Delete()
        {
            Console.WriteLine("Allowed to delete");
        }
    }
}
