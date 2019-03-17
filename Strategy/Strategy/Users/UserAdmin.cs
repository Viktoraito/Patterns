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
    class UserAdmin : UserBase
    {
        public UserAdmin()
        {
            //Admin allowed to: everyting
            BehaviorAdd = new Adding();
            BehaviorEdit = new Editing();
            BehaviorDelete = new Deleting();
        }
        public override void Who()
        {
            Console.WriteLine("I am ***4DM1N15TR4T0R***");
        }
    }
}
