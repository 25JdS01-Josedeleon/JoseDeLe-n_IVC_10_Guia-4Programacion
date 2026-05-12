internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------KILO DE MANZANAS-------------");

        double peso = 0;
        double total = 0;

        while (total < 1)
        {
            Console.WriteLine("Coloca una manzana en la bascula");
            Console.WriteLine("Ingrese el peso en kg:");

            peso = Convert.ToDouble(Console.ReadLine());

            total = total + peso;

            Console.WriteLine("Peso acumulado: " + total + " kg");
            Console.WriteLine();
        }

        Console.WriteLine("------------Ya tienes 1 kilogramo o mas de manzanas-----------");
    }
}