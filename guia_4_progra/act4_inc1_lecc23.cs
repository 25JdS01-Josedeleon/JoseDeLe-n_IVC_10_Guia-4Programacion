internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int a = num * i;
            Console.WriteLine(a);
        }
    }
}
