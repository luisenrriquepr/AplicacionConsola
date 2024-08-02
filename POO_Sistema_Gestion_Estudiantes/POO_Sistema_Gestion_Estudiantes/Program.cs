using System;

class Program
{
    static void Main()
    {
        GestorDeEstudiantes gestor = new GestorDeEstudiantes();
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
                    Console.WriteLine("Introduce el nombre del estudiante:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce la edad del estudiante:");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el curso del estudiante:");
                    string curso = Console.ReadLine();
                    Estudiante nuevoEstudiante = new Estudiante(nombre, edad, curso);
                    gestor.AgregarEstudiante(nuevoEstudiante);
                    break;
                case "2":
                    gestor.MostrarEstudiantes();
                    Console.WriteLine("Introduce el número del estudiante a eliminar:");
                    int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                    gestor.EliminarEstudiante(indice);
                    break;
                case "3":
                    gestor.MostrarEstudiantes();
                    break;
            }
        } while (opcion != "4");
    }
}
