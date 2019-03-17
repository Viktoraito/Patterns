using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CatPedigree : CatHome //Породистые котики
    {
        public string Name {get; set;}

        public void Meow()
        {
            Console.WriteLine("Nyaaaaa~");
        }

        public void Scratch()
        {
            Console.WriteLine("=^w^=");
        }
    }
}
