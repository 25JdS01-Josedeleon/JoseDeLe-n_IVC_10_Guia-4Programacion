using System;

class Program
{
    static void Main()
    {
        int sumaMultiplos = 0;
        int contadorPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            int multiplo = i * 7;
            sumaMultiplos += multiplo;

            if (multiplo % 2 == 0)
            {
                contadorPares++;
            }
        }

        Console.WriteLine($"La sumatoria de los primeros 20 múltiplos de 7 es: {sumaMultiplos}");
        Console.WriteLine($"Cantidad de esos múltiplos que son pares: {contadorPares}");
    }
}
