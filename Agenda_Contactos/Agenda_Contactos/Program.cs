using System;
using System.Collections.Generic;

class AgendaDeContactos
{
    static List<string> contactos = new List<string>();

    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Eliminar contacto");
            Console.WriteLine("3. Ver contactos");
            Console.WriteLine("4. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarContacto();
                    break;
                case "2":
                    EliminarContacto();
                    break;
                case "3":
                    VerContactos();
                    break;
            }
        } while (opcion != "4");
    }

    static void AgregarContacto()
    {
        Console.WriteLine("Introduce el nombre del contacto:");
        string contacto = Console.ReadLine();
        contactos.Add(contacto);
        Console.WriteLine("Contacto agregado.");
    }

    static void EliminarContacto()
    {
        VerContactos();
        Console.WriteLine("Introduce el número del contacto a eliminar:");
        int numero = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numero >= 0 && numero < contactos.Count)
        {
            contactos.RemoveAt(numero);
            Console.WriteLine("Contacto eliminado.");
        }
        else
        {
            Console.WriteLine("Número de contacto no válido.");
        }
    }

    static void VerContactos()
    {
        Console.WriteLine("Contactos:");
        for (int i = 0; i < contactos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {contactos[i]}");
        }
    }
}
