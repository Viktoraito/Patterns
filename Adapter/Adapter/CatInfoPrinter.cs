using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    sealed class CatInfoPrinter
    {
        public static void PrintCatInfo(CatHome cat) //недоступный для изменения класс, под КОТорый создается адаптер
        {
            Console.WriteLine("Cat Info:");
            Console.WriteLine(String.Format("Name: {0}",cat.Name));
            Console.Write("Meowing: ");
            cat.Meow();
            Console.Write("Scratching: ");
            cat.Scratch();
        }
    }
}
