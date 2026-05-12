using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        Console.WriteLine("Números primos encontrados:");

        for (int n = 2; n <= 22; n++)
        {
            if (EsPrimo(n))
            {
                Console.WriteLine(n);
                suma += n;
            }
        }

        Console.WriteLine($"\nLa suma total de los números primos entre 1 y 22 es: " + suma);
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}