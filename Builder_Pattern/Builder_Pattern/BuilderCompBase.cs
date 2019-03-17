using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public abstract class BuilderCompBase
    {
        protected ProductComputer PC;
        public BuilderCompBase()
        {
            PC = new ProductComputer();

        }

        public void setProductComputer(ProductComputer PC)
        {
            this.PC = PC;
        }

        public ProductComputer getProductComputer() {
            return PC;
        }

        public abstract void BuildBOX();
        public abstract void BuildHDD();
        public abstract void BuildPOWER();
        public virtual String BuildPROCESSOR(String xTypeProc) {
            xTypeProc = " Intel x86";
            PC.PROCESSOR = xTypeProc;
            return PC.PROCESSOR;
        }
        public abstract void BuildRAM();
        public abstract void BuildVIDEOCARD();  
    }
}
