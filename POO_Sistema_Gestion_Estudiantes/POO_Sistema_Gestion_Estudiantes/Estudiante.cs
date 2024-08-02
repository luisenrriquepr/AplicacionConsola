using System;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }

    public Estudiante(string nombre, int edad, string curso)
    {
        Nombre = nombre;
        Edad = edad;
        Curso = curso;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Curso: {Curso}");
    }
}
