using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ToCatHome : CatHome
    {
        private CatWild aCatWild; //экземпляр 2го класса

        public ToCatHome(CatWild xCatWild) {
            aCatWild = xCatWild;
        }
        public string Name
        {
            get {return aCatWild.Breed;}
            set { }
        }
        public void Meow() {
            aCatWild.Growl();
        }
        public void Scratch() {
            aCatWild.Scratch();
        }
    }
}
