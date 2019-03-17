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
    class UserEditor : UserBase
    {
        public UserEditor()
        {
            //Editor allowed to: Editing, Reading
            BehaviorEdit = new Editing();
        }
        public override void Who()
        {
            Console.WriteLine("I am Editor");
        }
    }
}
