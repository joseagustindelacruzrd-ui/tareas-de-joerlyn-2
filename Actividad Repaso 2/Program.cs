using System;

class Program
{
    static void Main()
    {
        int capacidad = 20;

        Console.WriteLine("=== AUTOBUS PLATINUM ===");

        Console.Write("Cantidad de pasajeros: ");
        int pasajeros = int.Parse(Console.ReadLine());

        int precio = 1000; // puedes cambiarlo
        int ventas = pasajeros * precio;

        int asientosDisponibles = capacidad - pasajeros;

        Console.WriteLine($"Auto Bus Platinum {pasajeros} Pasajeros");
        Console.WriteLine($"Ventas {ventas}");
        Console.WriteLine($"Quedan {asientosDisponibles} asientos disponibles");

        Console.WriteLine("\n=== AUTOBUS GOLD ===");

        Console.Write("Cantidad de pasajeros: ");
        pasajeros = int.Parse(Console.ReadLine());

        precio = 800; // otro precio
        ventas = pasajeros * precio;

        asientosDisponibles = capacidad - pasajeros;

        Console.WriteLine($"Auto Bus Gold {pasajeros} Pasajeros");
        Console.WriteLine($"Ventas {ventas}");
        Console.WriteLine($"Quedan {asientosDisponibles} asientos disponibles");
    }
}