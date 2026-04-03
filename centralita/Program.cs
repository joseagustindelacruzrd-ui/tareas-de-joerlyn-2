using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        CentralitaDB db = new CentralitaDB();
        db.CrearTabla();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ CENTRALITA ---");
            Console.WriteLine("1. Registrar llamada");
            Console.WriteLine("2. Ver llamadas");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Número de origen: ");
                    string origen = Console.ReadLine();

                    Console.Write("Número de destino: ");
                    string destino = Console.ReadLine();

                    Console.Write("Duración: ");
                    int duracion = int.Parse(Console.ReadLine());

                    Console.Write("Costo: ");
                    decimal costo = decimal.Parse(Console.ReadLine());

                    Llamada llamada = new Llamada
                    {
                        NumeroOrigen = origen,
                        NumeroDestino = destino,
                        Duracion = duracion,
                        Costo = costo
                    };

                    db.InsertarLlamada(llamada);
                    Console.WriteLine("Llamada registrada correctamente.");
                    break;

                case "2":
                    List<Llamada> llamadas = db.ObtenerLlamadas();

                    Console.WriteLine("\n--- LISTA DE LLAMADAS ---");
                    foreach (var l in llamadas)
                    {
                        Console.WriteLine($"ID: {l.Id}");
                        Console.WriteLine($"Origen: {l.NumeroOrigen}");
                        Console.WriteLine($"Destino: {l.NumeroDestino}");
                        Console.WriteLine($"Duración: {l.Duracion}");
                        Console.WriteLine($"Costo: {l.Costo}");
                        Console.WriteLine("---------------------------");
                    }
                    break;

                case "3":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
