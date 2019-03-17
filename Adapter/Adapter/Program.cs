using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CatHome Vasya = new CatYard();
            Vasya.Name = "Vasya";
            CatInfoPrinter.PrintCatInfo(Vasya); //неизменяемая функция, доставшаяся по наследству
            CatHome Einstein = new CatPedigree();
            Einstein.Name = "Einstein";
            CatInfoPrinter.PrintCatInfo(Einstein);
            Console.ReadKey();
            CatWild Taiga = new CatTiger();
            CatInfoPrinter.PrintCatInfo(new ToCatHome(Taiga));
            Console.ReadKey();
        }
    }
}
