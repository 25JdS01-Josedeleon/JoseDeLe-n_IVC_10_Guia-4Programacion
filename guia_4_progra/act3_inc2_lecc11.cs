using System;

class Program
{
    static void Main()
    {
        int numeroIngresado;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un número (ingrese 9 para terminar y ver el resultado): ");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            if (numeroIngresado != 9)
            {
                suma += numeroIngresado;
            }

        } while (numeroIngresado != 9);

        Console.WriteLine($"La suma total de los números ingresados es: {suma}");
    }
}
