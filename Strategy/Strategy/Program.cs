using Strategy.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAdmin Adm = new UserAdmin();
            UserEditor Edr = new UserEditor();
            UserGuest Gst = new Users.UserGuest();

            List<UserBase> UList = new List<UserBase>();
            UList.Add(new UserAdmin());
            UList.Add(new UserEditor());
            UList.Add(new UserGuest());

            foreach(var iUser in UList)
            {
                iUser.Who();
                iUser.Add();
                iUser.Delete();
                iUser.Edit();
                iUser.Read();
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
