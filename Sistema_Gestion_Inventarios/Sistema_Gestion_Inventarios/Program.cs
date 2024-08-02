using System;
using System.Collections.Generic;

class Producto
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}

class GestionDeInventarios
{
    static List<Producto> inventario = new List<Producto>();

    static void Main()
    {
        string opcion;

        do
        {
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Ver inventario");
            Console.WriteLine("4. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto();
                    break;
                case "2":
                    EliminarProducto();
                    break;
                case "3":
                    VerInventario();
                    break;
            }
        } while (opcion != "4");
    }

    static void AgregarProducto()
    {
        Console.WriteLine("Introduce el nombre del producto:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Introduce la cantidad del producto:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el precio del producto:");
        decimal precio = Convert.ToDecimal(Console.ReadLine());

        inventario.Add(new Producto { Nombre = nombre, Cantidad = cantidad, Precio = precio });
        Console.WriteLine("Producto agregado.");
    }

    static void EliminarProducto()
    {
        VerInventario();
        Console.WriteLine("Introduce el número del producto a eliminar:");
        int numero = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numero >= 0 && numero < inventario.Count)
        {
            inventario.RemoveAt(numero);
            Console.WriteLine("Producto eliminado.");
        }
        else
        {
            Console.WriteLine("Número de producto no válido.");
        }
    }

    static void VerInventario()
    {
        Console.WriteLine("Inventario:");
        for (int i = 0; i < inventario.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {inventario[i].Nombre} - Cantidad: {inventario[i].Cantidad} - Precio: {inventario[i].Precio:C}");
        }
    }
}
