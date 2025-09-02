using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Lista
    {
        Nodo header;
        public Lista() { header = null; }

        public void agregar(int id, Cursos notas)
        {
            Nodo nuevo = new Nodo(id, notas);
            if (header == null) { header = nuevo; return; }

            Nodo position = header;
            while (position.Next != null)
            {
                position = position.Next;
            }
            position.Next = nuevo;
        }
        public void Imprimir(DataGridView dataG)
        {
            dataG.Rows.Clear();
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            Nodo Print = header;
            while (Print != null)
            {
                dataG.Rows.Add(
                    Print.Id.ToString().Trim(),
                    Print.Notas.Nota1.ToString().Trim(),
                    Print.Notas.Nota2.ToString().Trim(),
                    Print.Notas.Nota3.ToString().Trim()
                    );
                Print = Print.Next;
            }
        }
        public void Buscar(int id, DataGridView dataG)
        {
            Nodo busq = header;
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            while (busq != null && busq.Id != id)
            {
                busq = busq.Next;
            }
            if (busq == null) { MessageBox.Show("Id de alumno no encontrado"); return; }

            if (busq.Notas.Nota1 < 5 || busq.Notas.Nota2 < 5 || busq.Notas.Nota3 < 5) dataG.BackgroundColor = Color.IndianRed;
            else dataG.BackgroundColor = Color.LightGreen;

            dataG.Rows.Clear();
            dataG.Rows.Add(
                    busq.Id.ToString().Trim(),
                    busq.Notas.Nota1.ToString().Trim(),
                    busq.Notas.Nota2.ToString().Trim(),
                    busq.Notas.Nota3.ToString().Trim()
                    );
        }

        public void Eliminar_Nota1()
        {
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            while (header.Notas.Nota1 < 5) { header = header.Next; }
            if (header == null) return;
            Nodo delete = header;
            while (delete.Next != null)
            {
                if (delete.Next.Notas.Nota1 < 5) delete.Next = delete.Next.Next;
                else delete = delete.Next;
            }
        }
        public void Eliminar_Nota2()
        {
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            while (header.Notas.Nota2 < 5) { header = header.Next; }
            if (header == null) return;
            Nodo delete = header;
            while (delete.Next != null)
            {
                if (delete.Next.Notas.Nota2 < 5) delete.Next = delete.Next.Next;
                else delete = delete.Next;
            }
        }
        public void Eliminar_Nota3()
        {
            if (header == null) { MessageBox.Show("Lista vacia"); return; }
            while (header.Notas.Nota3 < 5) { header = header.Next; }
            if (header == null) return;
            Nodo delete = header;
            while (delete.Next != null)
            {
                if (delete.Next.Notas.Nota3 < 5) delete.Next = delete.Next.Next;
                else delete = delete.Next;
            }
        }
    }
}
