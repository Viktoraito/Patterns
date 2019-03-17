using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase cupOfCap = new Cappucino();
            BeverageBase cupOfEsp = new Espresso();
            BeverageBase cupOfTea = new BlackTea();
            BeverageBase cupOfHot = new HotChocolate();
            Console.WriteLine("Drink: {0}\n\tPrice: {1}",cupOfCap.getDescription(),cupOfCap.getCost());
            Console.WriteLine("Drink: {0}\n\tPrice: {1}", cupOfEsp.getDescription(), cupOfEsp.getCost());
            Console.WriteLine("Drink: {0}\n\tPrice: {1}", cupOfTea.getDescription(), cupOfTea.getCost());
            Console.WriteLine("Drink: {0}\n\tPrice: {1}", cupOfHot.getDescription(), cupOfHot.getCost());
            Console.ReadKey();
        }
    }
}
