namespace RideApp
{
    public class Conductor : Usuario
    {
        public Vehiculo Vehiculo { get; set; }
        public bool Disponible { get; set; }

        public Conductor(int id, string nombre, Vehiculo vehiculo)
            : base(id, nombre)
        {
            Vehiculo = vehiculo;
            Disponible = true;
        }
    }
}