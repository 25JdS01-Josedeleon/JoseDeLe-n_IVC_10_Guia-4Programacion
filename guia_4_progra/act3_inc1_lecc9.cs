using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un número entero:");
        int num = Convert.ToInt32(Console.ReadLine());

        int actual = 20;

        Console.WriteLine($"\nLos números impares entre 20 y "+num+" son:");

        if (num < 20)
        {
            while (actual >= num)
            {
                if (actual % 2 != 0) 
                {
                    Console.WriteLine(actual);
                }
                actual--; 
            }
        }
        else
        {
            while (actual <= num)
            {
                if (actual % 2 != 0)
                {
                    Console.WriteLine(actual);
                }
                actual++;
            }
        }
    }
}