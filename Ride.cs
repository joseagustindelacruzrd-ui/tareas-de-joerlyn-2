using System;

namespace RideApp
{
    public class Ride
    {
        public Cliente Cliente { get; set; }
        public Conductor Conductor { get; set; }
        public double Distancia { get; set; }
        public double Precio { get; set; }
        public bool Completado { get; set; }

        public Ride(Cliente cliente, Conductor conductor, double distancia)
        {
            Cliente = cliente;
            Conductor = conductor;
            Distancia = distancia;
            Precio = 50 + (distancia * 20);
            Completado = false;
        }

        public void CompletarRide()
        {
            Completado = true;
            Conductor.Disponible = true;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Cliente: {Cliente.Nombre} | Conductor: {Conductor.Nombre} | Precio: {Precio} | Estado: {(Completado ? "Completado" : "En curso")}");
        }
    }
}