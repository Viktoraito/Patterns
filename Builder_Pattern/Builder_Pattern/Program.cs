using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сборка по частям
            ProductComputer PC0;
            //Standart
            Console.WriteLine("Standart Edition");
            BuilderCompBase BC_S = new BuilderCompStandart();
            Console.WriteLine("/1 Base Level");
            BC_S.BuildBOX(); BC_S.BuildPOWER(); BC_S.BuildPROCESSOR("");
            PC0 = BC_S.getProductComputer();
            Console.WriteLine(PC0);
            Console.WriteLine("/2 Base Level witn Option");
            BC_S.BuildHDD(); BC_S.BuildPROCESSOR(" Intel i4");
            PC0 = BC_S.getProductComputer();
            Console.WriteLine(PC0);
            Console.WriteLine("/3 Base Level Full Complectation");
            BC_S.BuildRAM(); BC_S.BuildVIDEOCARD();
            PC0 = BC_S.getProductComputer();
            Console.WriteLine(PC0);
            Console.ReadKey();
            //Premium
            Console.WriteLine("\n$$$ PrEmIuM EdItIoN $$$");
            BuilderCompBase BC_P = new BuilderCompPremium();
            Console.WriteLine("/1 Base Level");
            BC_P.BuildBOX(); BC_P.BuildPOWER(); BC_P.BuildPROCESSOR("");
            PC0 = BC_P.getProductComputer();
            Console.WriteLine(PC0);
            Console.WriteLine("/2 Base Level witn Option");
            BC_P.BuildHDD(); BC_P.BuildPROCESSOR(" Alien T-1000");
            PC0 = BC_P.getProductComputer();
            Console.WriteLine(PC0);
            Console.WriteLine("/3 Base Level Full Complectation");
            BC_P.BuildRAM(); BC_P.BuildVIDEOCARD();
            PC0 = BC_P.getProductComputer();
            Console.WriteLine(PC0);
            Console.ReadKey();
            //Director
            Console.WriteLine("\nBuilding by Director");
            Director BC_D = new Director();
            ProductComputer PC1;
            BC_S = new BuilderCompStandart();
            BC_P = new BuilderCompPremium();
            Console.WriteLine("/1 Standart Edition");
            BC_D.Construct(BC_S, " intel i3");
            PC1 = BC_S.getProductComputer();
            Console.WriteLine(PC1);
            Console.WriteLine("/2 $$$ PrEmIuM EdItIoN $$$");
            BC_D.Construct(BC_P, " intel i13");
            PC1 = BC_P.getProductComputer();
            Console.WriteLine(PC1);
            Console.ReadKey();
        }
    }
}
