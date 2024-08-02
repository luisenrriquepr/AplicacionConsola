using System;

class AdivinarNumero
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;
        int adivinanza = 0;

        Console.WriteLine("Adivina el número entre 1 y 100:");

        while (adivinanza != numeroSecreto)
        {
            adivinanza = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (adivinanza < numeroSecreto)
            {
                Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
            }
            else if (adivinanza > numeroSecreto)
            {
                Console.WriteLine("Demasiado alto. Intenta de nuevo:");
            }
        }

        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
    }
}
