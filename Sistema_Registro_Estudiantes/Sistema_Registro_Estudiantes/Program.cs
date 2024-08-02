using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }
}

class RegistroDeEstudiantes
{
    static List<Estudiante> estudiantes = new List<Estudiante>();

    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Eliminar estudiante");
            Console.WriteLine("3. Ver estudiantes");
            Console.WriteLine("4. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEstudiante();
                    break;
                case "2":
                    EliminarEstudiante();
                    break;
                case "3":
                    VerEstudiantes();
                    break;
            }
        } while (opcion != "4");
    }

    static void AgregarEstudiante()
    {
        Console.WriteLine("Introduce el nombre del estudiante:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Introduce la edad del estudiante:");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el curso del estudiante:");
        string curso = Console.ReadLine();

        estudiantes.Add(new Estudiante { Nombre = nombre, Edad = edad, Curso = curso });
        Console.WriteLine("Estudiante agregado.");
    }

    static void EliminarEstudiante()
    {
        VerEstudiantes();
        Console.WriteLine("Introduce el número del estudiante a eliminar:");
        int numero = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numero >= 0 && numero < estudiantes.Count)
        {
            estudiantes.RemoveAt(numero);
            Console.WriteLine("Estudiante eliminado.");
        }
        else
        {
            Console.WriteLine("Número de estudiante no válido.");
        }
    }

    static void VerEstudiantes()
    {
        Console.WriteLine("Estudiantes:");
        for (int i = 0; i < estudiantes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {estudiantes[i].Nombre} - Edad: {estudiantes[i].Edad} - Curso: {estudiantes[i].Curso}");
        }
    }
}
