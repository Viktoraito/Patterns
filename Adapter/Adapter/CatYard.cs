using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CatYard : CatHome //Дворовые котики
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Myaaaaw!!");
        }

        public void Scratch()
        {
            Console.WriteLine("=ОwО= *soft scratch*");
        }
    }
}
