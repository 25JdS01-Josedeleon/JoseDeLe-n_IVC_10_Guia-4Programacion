using System;

class Program
{
    static void Main()
    {
        int contadorPrimos = 0;
        int sumaPrimos = 0;

        for (int num = 1; num <= 100; num++)
        {
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
                sumaPrimos += num;
            }
        }

        Console.WriteLine($"Cantidad de números primos: {contadorPrimos}");
        Console.WriteLine($"La suma de los números primos es: {sumaPrimos}");
    }
}