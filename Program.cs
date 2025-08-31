// See https://aka.ms/new-console-template for more information

using Laboratorio_2.Problema_2;
using Laboratorio_2.Problema_3;
using Problema2;
using System.Data;

Lista1 list1 = new Lista1();
Lista2 list2 = new Lista2();

//Problema 3
Lista3 list3 = new Lista3();
Lista3 list3_enlazar = new Lista3();
Lista3 newLista = new Lista3();

while (true)
{
    Console.WriteLine(@"**** Elija uno de los problemas ****
     1. Problema 1
     2. Problema 2
     3. Problema 3");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Problem1();
            Console.Clear();
            break;
        case 2:
            Problem2();
            Console.Clear();
            break;
        case 3:
            Problem3();
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            Console.WriteLine("Opción no válida");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

void Problem1()
{
    bool activate = false;
    bool Activate_Problem = true;
    while (Activate_Problem)
    {
        Console.WriteLine(@"
            **** Registro de números ****
            Elije una opción
            1. Insertar número
            2. Ver lista
            3. Ordenar lista
            4. Salir
            Elije una opción: ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                activate = true;
                while (activate == true)
                {
                    Console.Write("Número: "); int numero = Convert.ToInt32(Console.ReadLine());
                    list1.agregar(numero);
                    Console.WriteLine("¿Desea registrar otro número? 1.Si 2.No");
                    string opcion = Console.ReadLine();
                    if (opcion == "2") { activate = false; Console.Clear(); }
                }
                break;
            case 2:
                list1.Imprimir();
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                list1.ordenar_Asendente();
                Console.WriteLine("Lista ordenada");
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                Console.Clear();
                Activate_Problem = false;
                break;
            default:
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
}
void Problem2()
{
    bool activate = false;
    bool Activate_Problem = true;
    while (Activate_Problem)
    {
        Console.WriteLine(@"
            **** Registro de números ****
            Elije una opción
            1. Insertar número
            2. Ver lista
            3. Buscar un número
            4. Salir
            Elije una opción: ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                activate = true;
                while (activate == true)
                {
                    Console.Write("Número: "); int numero = Convert.ToInt32(Console.ReadLine());
                    list2.agregar(numero);
                    Console.WriteLine("¿Desea registrar otro número? 1.Si 2.No");
                    string opcion = Console.ReadLine();
                    if (opcion == "2") { activate = false; Console.Clear(); }
                }
                break;
            case 2:
                list2.Imprimir();
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                Console.Write("Número: "); int number = Convert.ToInt32(Console.ReadLine());
                list2.ImprimirNumEspecifico(number);
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                Console.Clear();
                Activate_Problem = false;
                break;
            default:
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
}
void Problem3()
{
    bool activate = false;
    bool Activate_Problem = true;
    while (Activate_Problem)
    {
        Console.WriteLine(@"
            **** Registro de números ****
            Elije una opción
            1. Insertar número en lista 1
            2. Insertar número en lista 2
            3. Ver lista Mezcla
            4. Ver lista 1
            5. Ver lista 2
            6. Mezclar Listas
            7. Salir
            Elije una opción: ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                activate = true;
                while (activate == true)
                {
                    Console.Write("Número: "); int numero = Convert.ToInt32(Console.ReadLine());
                    Datos nuevo = new Datos(numero);
                    list3.Agregar(nuevo);
                    Console.WriteLine("¿Desea registrar otro número? 1.Si 2.No");
                    string opcion = Console.ReadLine();
                    if (opcion == "2") { activate = false; Console.Clear(); }
                }
                break;
            case 2:
                activate = true;
                while (activate == true)
                {
                    Console.Write("Número: "); int numero2 = Convert.ToInt32(Console.ReadLine());
                    Datos nuevo2 = new Datos(numero2);
                    list3_enlazar.Agregar(nuevo2);
                    Console.WriteLine("¿Desea registrar otro número? 1.Si 2.No");
                    string opcion2 = Console.ReadLine();
                    if (opcion2 == "2") { activate = false; Console.Clear(); }
                }
                break;
            case 3:
                list3.ImprimirNumLista(newLista);
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                list3.ImprimirNumLista(list3);
                Console.ReadKey();
                Console.Clear();
                break;
            case 5:
                list3.ImprimirNumLista(list3_enlazar);
                Console.ReadKey();
                Console.Clear();
                break;
            case 6:
                newLista = Lista3.MezclarListas(list3, list3_enlazar);
                Console.ReadKey();
                Console.Clear();
                break;
            case 7:
                Console.Clear();
                Activate_Problem = false;
                break;
            default:
                Console.WriteLine("Opción no válida");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
}