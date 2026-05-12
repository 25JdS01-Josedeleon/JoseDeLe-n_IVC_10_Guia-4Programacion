internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int suma = 0;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 1; i--)
        {
            Console.WriteLine(i);
            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}