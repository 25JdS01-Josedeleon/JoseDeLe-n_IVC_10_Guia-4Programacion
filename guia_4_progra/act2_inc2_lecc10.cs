internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NUMEROS PARES");

        int num;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}