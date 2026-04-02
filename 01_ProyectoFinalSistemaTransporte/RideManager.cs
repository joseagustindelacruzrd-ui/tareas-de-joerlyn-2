using System;
using System.Collections.Generic;
using System.Linq;

namespace RideApp
{
    public class RideManager
    {
        public List<Cliente> Clientes = new();
        public List<Conductor> Conductores = new();
        public List<Ride> Rides = new();

        public void RegistrarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void RegistrarConductor(Conductor conductor)
        {
            Conductores.Add(conductor);
        }

        public void SolicitarRide(int clienteId, double distancia)
        {
            var cliente = Clientes.FirstOrDefault(c => c.Id == clienteId);
            var conductor = Conductores.FirstOrDefault(c => c.Disponible);

            if (cliente == null || conductor == null)
            {
                Console.WriteLine("Error: cliente o conductor no disponible");
                return;
            }

            conductor.Disponible = false;

            Ride ride = new Ride(cliente, conductor, distancia);
            Rides.Add(ride);

            Console.WriteLine("Ride creado:");
            ride.MostrarInfo();
        }

        public void MostrarRides()
        {
            foreach (var ride in Rides)
            {
                ride.MostrarInfo();
            }
        }
    }
}