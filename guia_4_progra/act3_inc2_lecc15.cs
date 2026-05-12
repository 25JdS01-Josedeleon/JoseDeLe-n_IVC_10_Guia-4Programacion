using System;

class Program
{
    static void Main()
    {
        int contadorPrimos = 0;
        int sumaPares = 0;

        for (int num = 300; num >= 1; num--)
        {
            if (num % 2 == 0)
            {
                sumaPares += num;
            }

            int divisores = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine($"Cantidad de números primos encontrados: {contadorPrimos}");
        Console.WriteLine($"La suma de los números pares es: {sumaPares}");
    }
}