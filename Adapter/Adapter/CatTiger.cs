using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CatTiger : CatWild //тигрули
    {
        public string Breed
        {
            get {
            return "White tiger";
                     }     
        }
        public void Growl()
        {
            Console.WriteLine("Raaawr!~");
        }
      
        public void Scratch()
        {
            Console.WriteLine("=XwX= *deadly scratch*");
        }
    }
}
