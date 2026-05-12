internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 1; i <= 50; i++)
        {
            bool esPrimo = true;

            if (i <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                suma += i;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);
    }
}
