using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Nodo
    {
        public int dato { get; set; }
        public Nodo siguiente { get; set; }

        public Nodo(int Dato)
        {
            dato = Dato;
        }

        public override string ToString()
        {
            return "Dato: " + dato;
        }
    }
}
