using System;
using System.Collections.Generic;

class GestorDeEstudiantes
{
    private List<Estudiante> estudiantes = new List<Estudiante>();

    public void AgregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
        Console.WriteLine("Estudiante agregado.");
    }

    public void EliminarEstudiante(int indice)
    {
        if (indice >= 0 && indice < estudiantes.Count)
        {
            estudiantes.RemoveAt(indice);
            Console.WriteLine("Estudiante eliminado.");
        }
        else
        {
            Console.WriteLine("Índice no válido.");
        }
    }

    public void MostrarEstudiantes()
    {
        Console.WriteLine("Lista de Estudiantes:");
        for (int i = 0; i < estudiantes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {estudiantes[i].Nombre}, {estudiantes[i].Edad}, {estudiantes[i].Curso}");
        }
    }
}
