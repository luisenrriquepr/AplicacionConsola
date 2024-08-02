using System;
using System.Collections.Generic;

class GestorDeTareas
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Ver tareas");
            Console.WriteLine("4. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarTarea();
                    break;
                case "2":
                    EliminarTarea();
                    break;
                case "3":
                    VerTareas();
                    break;
            }
        } while (opcion != "4");
    }

    static void AgregarTarea()
    {
        Console.WriteLine("Introduce la descripción de la tarea:");
        string tarea = Console.ReadLine();
        tareas.Add(tarea);
        Console.WriteLine("Tarea agregada.");
    }

    static void EliminarTarea()
    {
        VerTareas();
        Console.WriteLine("Introduce el número de la tarea a eliminar:");
        int numero = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numero >= 0 && numero < tareas.Count)
        {
            tareas.RemoveAt(numero);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número de tarea no válido.");
        }
    }

    static void VerTareas()
    {
        Console.WriteLine("Tareas:");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }
}
