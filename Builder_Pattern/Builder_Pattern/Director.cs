using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class Director
    {
        public void Construct(BuilderCompBase xBuilderComp, String xTypeProc)
        {
            xBuilderComp.BuildBOX();
            xBuilderComp.BuildHDD();
            xBuilderComp.BuildPOWER();
            xBuilderComp.BuildPROCESSOR(xTypeProc);
            xBuilderComp.BuildRAM();
            xBuilderComp.BuildVIDEOCARD();
        }
    }
}
