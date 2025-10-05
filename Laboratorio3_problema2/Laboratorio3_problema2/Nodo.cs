using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_problema2
{
    public class Nodo
    {
        public Numeros numeros;
        public Nodo next;
        public Nodo(Numeros numeros)
        {
            this.numeros = numeros;
            next = null;
        }
    }
}
