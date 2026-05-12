using System;

class Program
{
    static void Main()
    {
        int totalBoletos = 0;
        double totalDinero = 0;
        int opcion = -1;

        Console.WriteLine("--- Control de Acceso: Rueda de la Fortuna ---");

        while (opcion != 0)
        {
            Console.WriteLine("\nElija una opción:");
            Console.WriteLine("1. Vender boleto Adulto ($15)");
            Console.WriteLine("2. Vender boleto Niño ($10)");
            Console.WriteLine("0. Salir y mostrar totales");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        totalBoletos++;
                        totalDinero += 15;
                        Console.WriteLine("Boleto de adulto sumado.");
                        break;
                    case 2:
                        totalBoletos++;
                        totalDinero += 10;
                        Console.WriteLine(" Boleto de niño sumado.");
                        break;
                    case 0:
                        Console.WriteLine("Generando reporte final...");
                        break;
                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("ACTUAL: " + totalBoletos + " boletos, Caja: " + totalDinero);
                }
            }
        }

        Console.WriteLine("\n======================================");
        Console.WriteLine("TOTAL DE BOLETOS VENDIDOS: " + totalBoletos);
        Console.WriteLine("TOTAL DINERO RECAUDADO: " + totalDinero);
        Console.WriteLine("======================================");
    }
}
