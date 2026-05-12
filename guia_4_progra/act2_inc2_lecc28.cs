using System;

class Program
{
    static void Main()
    {
        int totalBoletos = 0;
        int totalDinero = 0;
        string opcion = "";

        Console.WriteLine("--- SISTEMA DE CONTROL DE LA RUEDA DE LA FORTUNA ---");

        do
        {
            Console.WriteLine("\nSeleccione el tipo de boleto:");
            Console.WriteLine("1. Niño ($10)");
            Console.WriteLine("2. Adulto ($15)");
            Console.Write("Ingrese su opción (1 o 2): ");
            string tipoBoleto = Console.ReadLine();

 
            if (tipoBoleto == "1")
            {
                totalBoletos++; 
                totalDinero += 10; 
                Console.WriteLine("Boleto de niño registrado.");
            }
            else if (tipoBoleto == "2")
            {
                totalBoletos++; 
                totalDinero += 15; 
                Console.WriteLine("Boleto de adulto registrado.");
            }
            else
            {
                Console.WriteLine("Opción no válida. No se registró ningún boleto.");
            }

            Console.WriteLine("\n--- ESTADO ACTUAL ---");
            Console.WriteLine($"Número de boletos vendidos: {totalBoletos}");
            Console.WriteLine($"Total de dinero cobrado: ${totalDinero}");
            Console.WriteLine("----------------------");

            Console.Write("\n¿Desea registrar otro boleto? (S para Sí / N para No): ");
            opcion = Console.ReadLine().ToUpper();

        } while (opcion == "S");

        Console.WriteLine("\n¡Cierre de caja exitoso! Que tenga un buen día.");
    }
}
