using System;

namespace ActividadEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidadTotal = 200;
            int autosIngresados = 0;
            int cajonesLibres;

            do
            {
                cajonesLibres = capacidadTotal - autosIngresados;

                if (cajonesLibres > 0)
                {
                    Console.WriteLine("Cajones disponibles: cajonesLibres");
                    Console.WriteLine("Presiona Enter para registrar la entrada");
                    Console.ReadLine();
                    autosIngresados++;
                }

            } while (autosIngresados < capacidadTotal);

            Console.WriteLine("Ya no hay cajones libres. Estacionamiento lleno.");
        }
    }
}