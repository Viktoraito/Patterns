using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class BuilderCompStandart : BuilderCompBase
    {
        public BuilderCompStandart() : base() { }
        public override void BuildBOX()
        {
            PC.BOX = " Mini Tower";
        }
        public override void BuildHDD()
        {
            PC.HDD = " 500 GB";
        }
        public override void BuildPOWER()
        {
            PC.POWER = " 650 Watt";
        }
        public override string BuildPROCESSOR(string xTypeProc)
        {
            if (xTypeProc == "")
                PC.PROCESSOR = base.BuildPROCESSOR(xTypeProc);
            else
                PC.PROCESSOR = xTypeProc;
            return PC.PROCESSOR;
        }
        public override void BuildRAM()
        {
            PC.RAM = " 4 GB";
        }
        public override void BuildVIDEOCARD()
        {
            PC.VIDEOCARD = " GeForce GT 730";
        }


    }
}
