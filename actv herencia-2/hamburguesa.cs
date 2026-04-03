using System;

public class Hamburguesa
{
    protected string pan;
    protected string carne;
    protected double precioBase;

    protected string ing1;
    protected double p1;

    protected string ing2;
    protected double p2;

    protected string ing3;
    protected double p3;

    protected string ing4;
    protected double p4;

    public Hamburguesa(string pan, string carne, double precio)
    {
        this.pan = pan;
        this.carne = carne;
        this.precioBase = precio;
    }

    public virtual void AgregarIngrediente(string nombre, double precio)
    {
        if (ing1 == null)
        {
            ing1 = nombre;
            p1 = precio;
        }
        else if (ing2 == null)
        {
            ing2 = nombre;
            p2 = precio;
        }
        else if (ing3 == null)
        {
            ing3 = nombre;
            p3 = precio;
        }
        else if (ing4 == null)
        {
            ing4 = nombre;
            p4 = precio;
        }
        else
        {
            Console.WriteLine("Ya no caben más ingredientes");
        }
    }

    public virtual double Total()
    {
        return precioBase + p1 + p2 + p3 + p4;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Hamburguesa normal");
        Console.WriteLine("Pan: " + pan);
        Console.WriteLine("Carne: " + carne);
        Console.WriteLine("Base: " + precioBase);

        if (ing1 != null) Console.WriteLine(ing1 + " " + p1);
        if (ing2 != null) Console.WriteLine(ing2 + " " + p2);
        if (ing3 != null) Console.WriteLine(ing3 + " " + p3);
        if (ing4 != null) Console.WriteLine(ing4 + " " + p4);

        Console.WriteLine("Total: " + Total());
    }
}