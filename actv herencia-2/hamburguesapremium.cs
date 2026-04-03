using System;

public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium()
        : base("Pan brioche", "Carne premium", 400)
    {
    }

    public override void AgregarIngrediente(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes");
    }

    public override double Total()
    {
        return precioBase + 80 + 100; // papas + bebida
    }

    public override void Mostrar()
    {
        Console.WriteLine("Hamburguesa premium");
        Console.WriteLine("Incluye papas y bebida");
        Console.WriteLine("Total: " + Total());
    }
}