internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TABLA DE MULTIPLICAR");

        int num, resultado;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            resultado = num * i;
            Console.WriteLine(num + " x " + i + " = " + resultado);
        }
    }
}