using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Edit
{
    class Editing : IEditing
    {
        public void Edit()
        {
            Console.WriteLine("Allowed to edit");
        }
    }
}
