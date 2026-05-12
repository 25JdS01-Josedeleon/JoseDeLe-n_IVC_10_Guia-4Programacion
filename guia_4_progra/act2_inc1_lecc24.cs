internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            int mul = num * i;
            Console.WriteLine(mul);
        }
    }
}
