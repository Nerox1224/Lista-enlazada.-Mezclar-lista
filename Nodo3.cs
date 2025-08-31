using Laboratorio_2.Problema_2;
using Problema2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2.Problema_3
{
    public class Datos
    {
        public int Numero { get; set; }
        public Datos(int numero)
        {
            Numero = numero;
        }
    }
    public class Nodo3
    {
        public Datos Data { get; set; }
        public Nodo3 Next { get; set; }
        public Nodo3(Datos data)
        {
            Data = data;
            Next = null;
        }
    }
}
