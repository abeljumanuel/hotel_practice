using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2_Juan_Rojas
{
    class Persona
    {
        // Asignar los atributos
        public String id { get; set; }
        public String name { get; set; }
        public String tproom { get; set; }
        public int value { get; set; }
        public String sex { get; set; }
        public  int days { get; set; }
        public int CalculateTotal(int days, int value)
        {
            return days * value;
        }


    }
}
