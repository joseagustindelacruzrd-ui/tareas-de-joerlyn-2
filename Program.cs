using System;

namespace RideApp
{
    class Program
    {
        static void Main()
        {
            RideManager manager = new RideManager();
            int opcion;

            do
            {
                Console.WriteLine("\n=== SISTEMA DE RIDES ===");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Registrar conductor");
                Console.WriteLine("3. Solicitar ride");
                Console.WriteLine("4. Ver rides");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida.");
                    opcion = -1;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("ID del cliente: ");
                        int idCliente = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Nombre del cliente: ");
                        string nombreCliente = Console.ReadLine() ?? "";

                        manager.RegistrarCliente(new Cliente(idCliente, nombreCliente));
                        Console.WriteLine("Cliente registrado correctamente.");
                        break;

                    case 2:
                        Console.Write("ID del conductor: ");
                        int idConductor = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Nombre del conductor: ");
                        string nombreConductor = Console.ReadLine() ?? "";

                        Console.Write("Marca del vehículo: ");
                        string marca = Console.ReadLine() ?? "";

                        Console.Write("Modelo del vehículo: ");
                        string modelo = Console.ReadLine() ?? "";

                        manager.RegistrarConductor(
                            new Conductor(idConductor, nombreConductor, new Vehiculo(marca, modelo))
                        );

                        Console.WriteLine("Conductor registrado correctamente.");
                        break;

                    case 3:
                        Console.Write("ID del cliente: ");
                        int clienteIdRide = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Distancia del ride: ");
                        double distancia = double.Parse(Console.ReadLine() ?? "0");

                        manager.SolicitarRide(clienteIdRide, distancia);
                        break;

                    case 4:
                        Console.WriteLine("\n--- Todos los rides ---");
                        manager.MostrarRides();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}