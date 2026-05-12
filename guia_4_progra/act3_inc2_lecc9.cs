internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NUMERO PRIMO");

        int num, contador = 0;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contador = contador + 1;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("Es numero primo");
        }
        else
        {
            Console.WriteLine("No es numero primo");
        }
    }
}