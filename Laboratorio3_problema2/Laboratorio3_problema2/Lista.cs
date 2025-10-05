using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_problema2
{
    public class Lista
    {
        Nodo header;
        Lista Pares;
        Lista Impares;

        public void Insertar(Numeros numeros)
        {
            Nodo nuevo = new Nodo(numeros);
            if (header == null)
            {
                header = nuevo;
                header.next = header;
                return;
            }
            Nodo insertar = header;
            while (insertar.next != header) insertar = insertar.next;
            insertar.next = nuevo;
            nuevo.next = header;
        }
        public void ImprimirListaDeNumeros(DataGridView dataG)
        {
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            Nodo Print = header;
            dataG.Rows.Clear();
            do
            {
                dataG.Rows.Add(
                    Print.numeros.numero.ToString().Trim());
                Print = Print.next;
            } while (Print != header);
        }

        public void SepararListas()
        {
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            Pares = new Lista();
            Impares = new Lista();
            Nodo separar = header;
            do
            {
                int residuo = separar.numeros.numero % 2;
                if (residuo == 0) Pares.Insertar(new Numeros(separar.numeros.numero));
                else Impares.Insertar(new Numeros(separar.numeros.numero));
                separar = separar.next;
            } while (separar != header);
        }
        public void Imprimir_Listas(DataGridView dataG)
        {
            if (Pares.header == null) { MessageBox.Show("Lista vacia"); return; }
            Nodo Print = header;
            Nodo par = Pares.header;
            Nodo impar = Impares.header;
            dataG.Rows.Clear();
            do
            {
                dataG.Rows.Add(
                    Print.numeros.numero.ToString().Trim(),
                    par?.numeros.numero.ToString().Trim(),
                    impar?.numeros.numero.ToString().Trim());
                Print = Print.next;
                if (par.next != Pares.header) par = par.next;
                if (impar.next != Impares.header) impar = impar.next;
            } while (Print != header);
        }
    }
}
