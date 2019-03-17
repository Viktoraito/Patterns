using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class ProductComputer
    {
        public String BOX { get; set; }
        public String HDD { get; set; }
        public String POWER { get; set; }
        public String PROCESSOR { get; set; }
        public String RAM { get; set; }
        public String VIDEOCARD { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(" Корпус: \t\t {0}\n"+
                      " Жесткий диск: \t\t {1}\n"+
                      " Блок питания: \t\t {2}\n"+
                         " Процессор: \t\t {3}\n"+
                " Оперативная память: \t {4}\n"+
                        " Видеокарта: \t\t {5}\n",
            BOX, HDD, POWER, PROCESSOR, RAM, VIDEOCARD);
            return sb.ToString();
        }




    }
}
