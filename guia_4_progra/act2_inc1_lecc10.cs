internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MULTIPLOS DE 4");

        int resultado;

        for (int i = 1; i <= 20; i++)
        {
            resultado = 4 * i;
            Console.WriteLine(resultado);
        }
    }
}