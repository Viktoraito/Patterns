using Strategy.Add;
using Strategy.Delete;
using Strategy.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Users
{
    class UserGuest : UserBase
    {
        //constructor implements from parent
        public override void Who()
        {
            Console.WriteLine("I am Guest");
        }
    }
}
