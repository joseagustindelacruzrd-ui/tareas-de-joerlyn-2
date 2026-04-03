using System;

public class HamburguesaSaludable : Hamburguesa
{
    string extra1;
    double pe1;

    string extra2;
    double pe2;

    public HamburguesaSaludable(string carne, double precio)
        : base("Pan integral", carne, precio)
    {
    }

    public void AgregarExtra(string nombre, double precio)
    {
        if (extra1 == null)
        {
            extra1 = nombre;
            pe1 = precio;
        }
        else if (extra2 == null)
        {
            extra2 = nombre;
            pe2 = precio;
        }
        else
        {
            Console.WriteLine("No caben más extras");
        }
    }

    public override double Total()
    {
        return base.Total() + pe1 + pe2;
    }

    public override void Mostrar()
    {
        Console.WriteLine("Hamburguesa saludable");

        base.Mostrar();

        if (extra1 != null) Console.WriteLine("Extra: " + extra1 + " " + pe1);
        if (extra2 != null) Console.WriteLine("Extra: " + extra2 + " " + pe2);

        Console.WriteLine("Total final: " + Total());
    }
}