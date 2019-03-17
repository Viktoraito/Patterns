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
    public abstract class UserBase
    {
        //All users allowed to read
        public void Read()
        {
            Console.WriteLine("Allowed to read");
        }

        //Type of user
        public abstract void Who();

        protected IAdding BehaviorAdd;
        protected IEditing BehaviorEdit;
        protected IDeleting BehaviorDelete;

        //class Constructor
        public UserBase()
        {
            BehaviorAdd = new NoAdding();
            BehaviorDelete = new NoDeleting();
            BehaviorEdit = new NoEditing();
        }

        public void Add(){BehaviorAdd.Add();}
        public void Delete() { BehaviorDelete.Delete(); }
        public void Edit() { BehaviorEdit.Edit(); }
    }
}
