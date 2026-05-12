using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());


        int inicio = Math.Min(n1, n2);
        int fin = Math.Max(n1, n2);

        Console.WriteLine($"\nMúltiplos de 4 en el rango " + inicio + " - " + fin);

        for (int i = inicio; i <= fin; i++)
        {

            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
