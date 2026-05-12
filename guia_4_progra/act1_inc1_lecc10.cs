internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("[____BIENVENIDOS A LA BARBERIA DE CRUP____]");

        for (int i = 1; i <= TOTAL_SELLOS; i++)
        {
            Console.WriteLine("\nSello actual {0} de {1}", i, TOTAL_SELLOS);
            Console.WriteLine("Presione cualquier tecla para registrar esta visita...");
            Console.ReadKey();

            Console.WriteLine(">>Sellos #{0} registrado correctamente....");
            
        }
        Console.WriteLine("\n[____________________________________________]");
        Console.WriteLine("¡¡CUPONERA COMPLETA!!");
        Console.WriteLine("Orozco, has ganado un corte de cabello ¡¡GRATIS!!");
        Console.WriteLine("\n[____________________________________________]");

        Console.WriteLine("\nPresione una tecla para cerrar");
        Console.ReadKey();
    }
}