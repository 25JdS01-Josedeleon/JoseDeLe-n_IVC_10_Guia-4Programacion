using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n < 0)
            {
                Console.WriteLine("El factorial no existe para números negativos.");
            }
            else
            {

                double factorial = 1;
                int i = 1;

                if (n > 0)
                {
                    do
                    {
                        factorial *= i;
                        i++;
                    } while (i <= n);
                }

                Console.WriteLine("El factorial de " + n + "es: " + factorial);
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}
