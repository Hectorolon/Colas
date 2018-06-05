using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Cola
    {
        Proceso inicio = null;
        Proceso ultimo = null;

        public void encolar(Proceso nuevo)
        {
            if(inicio != null /*&& inicio.ciclos<0*/)
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
        }

        public void desencolar()
        {
            Proceso t = inicio;
            if (t.siguiente != null)
            {

                inicio = t.siguiente;
            }
            else
            {
                t = null;
            }

        }

        public Proceso ver()
        {
            return inicio;
        }
    }
}
