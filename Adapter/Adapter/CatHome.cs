using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface CatHome //Интерфейс домашних котиков
    {
        String Name { get; set; }
        void Meow();
        void Scratch();
    }
}
