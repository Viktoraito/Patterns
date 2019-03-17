using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class BuilderCompPremium : BuilderCompBase
    {
        public BuilderCompPremium() : base() { }
        public override void BuildBOX()
        {
            PC.BOX = " Giant Tower";
        }
        public override void BuildHDD()
        {
            PC.HDD = " 100500 TB";
        }
        public override void BuildPOWER()
        {
            PC.POWER = " 2000 Watt";
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
            PC.RAM = " 64 GB";
        }
        public override void BuildVIDEOCARD()
        {
            PC.VIDEOCARD = " Radeon 666000";
        }
    }
}
