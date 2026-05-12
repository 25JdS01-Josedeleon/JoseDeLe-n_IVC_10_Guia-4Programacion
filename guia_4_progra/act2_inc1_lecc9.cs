using System;

class Program
{
    static void Main()
    {
        int monedas;

        Console.WriteLine("Bienvenido al juego.");
        Console.WriteLine("¿Cuántas monedas tienes actualmente?");

        monedas = Convert.ToInt32(Console.ReadLine());
        while (monedas < 350)
        {
            Console.WriteLine($"\nNivel 5 BLOQUEADO. Tienes "+ monedas+ " monedas.");
            Console.WriteLine("Necesitas al menos 350 monedas para desbloquearlo.");
            Console.WriteLine();

            // Simulamos que el jugador recolecta más monedas
            Console.WriteLine("¿Cuántas monedas tienes ahora después de jugar?");
            monedas = Convert.ToInt32(Console.ReadLine());
            if (monedas >= 350)
            {
                Console.WriteLine("Puedes ingresar al nivel 5");
            }
            else
            {
                Console.WriteLine("Nivel 5 bloqueado, necesitas mas monedas");
            }
        }

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine($"¡FELICIDADES! Tienes {monedas} monedas.");
        Console.WriteLine("¡El Nivel 5 ha sido DESBLOQUEADO con éxito! Bienvenido.");
    }
}
