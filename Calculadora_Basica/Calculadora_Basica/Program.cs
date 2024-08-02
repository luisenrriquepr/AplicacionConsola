using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Introduce el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce la operación (+, -, *, /):");
        string operacion = Console.ReadLine();

        double resultado = 0;

        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operación no válida");
                break;
        }

        Console.WriteLine("El resultado es: " + resultado);
    }
}
