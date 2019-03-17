using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface CatWild //интерфейс диких котиков
    {
        string Breed { get; } //порода
        void Growl(); //рычание
        void Scratch();
    }
}
