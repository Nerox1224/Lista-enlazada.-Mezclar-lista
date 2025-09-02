using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Nodo
    {
        public int Id {  get; set; }
        public Cursos Notas {  get; set; }
        public Nodo Next { get; set; }
        public Nodo(int id,Cursos notas)
        {
            Id = id;
            Notas = notas;
            Next = null;
        }
    }
}
