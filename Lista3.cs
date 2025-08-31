using Laboratorio_2.GestionTareas;
using Problema2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_2.Problema_3
{
    public class Lista3
    {
        Nodo3 header { get; set; }
        public Lista3()
        {
            header = null;
        }
        public void Agregar(Datos data)
        {
            Nodo3 nuevo = new Nodo3(data);
            Nodo3 guardar = header;
            if (header == null) { header = nuevo; return; }
            while (guardar.Next != null)
            {
                guardar = guardar.Next;
            }
            guardar.Next = nuevo;
        }
        public void ImprimirNumLista(Lista3 list)
        {
            Nodo3 Print = list.header;
            if (list.header == null) { Console.WriteLine("Lista vacia"); return; }
            while (Print != null)
            {
                Console.WriteLine(Print.Data.Numero.ToString().Trim() + "\n");
                Print = Print.Next;
            }
        }
        public static Lista3 MezclarListas(Lista3 list1, Lista3 list2)
        {
            if (list1.header == null) { Console.WriteLine("Lista vacia"); return null; }
            Lista3 NewLista = new Lista3();
            Nodo3 nodo_1 = list1.header;
            Nodo3 nodo_2 = list2.header;
            while (nodo_1 != null || nodo_2 != null)
            {
                if (nodo_1 != null)
                {
                    NewLista.Agregar(nodo_1.Data);
                    nodo_1 = nodo_1.Next;
                }
                if (nodo_2 != null)
                {
                    NewLista.Agregar(nodo_2.Data);
                    nodo_2 = nodo_2.Next;
                }
            }
            Console.WriteLine("Listas Unidas");
            return NewLista;
        }
    }
}
