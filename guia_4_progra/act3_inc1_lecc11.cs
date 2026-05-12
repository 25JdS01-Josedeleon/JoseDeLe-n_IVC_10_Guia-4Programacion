using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int menor = Math.Min(num1, num2);
        int mayor = Math.Max(num1, num2);

        int suma = 0;
        int contador = menor; 

        do
        {
            suma += contador;
            contador++;
        } while (contador <= mayor);

        Console.WriteLine($"La suma de los enteros entre {menor} y {mayor} es: {suma}");
    }
}
