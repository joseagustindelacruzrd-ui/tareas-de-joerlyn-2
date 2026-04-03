using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CHIMI DE BILLY ===");

        // Hamburguesa normal
        Hamburguesa h1 = new Hamburguesa("Pan normal", "Carne de res", 200);
        h1.AgregarIngrediente("Queso", 25);
        h1.AgregarIngrediente("Tomate", 20);
        h1.Mostrar();

        Console.WriteLine();

        // Hamburguesa saludable
        HamburguesaSaludable h2 = new HamburguesaSaludable("Pollo", 250);
        h2.AgregarIngrediente("Lechuga", 15);
        h2.AgregarExtra("Aguacate", 40);
        h2.Mostrar();

        Console.WriteLine();

        // Hamburguesa premium
        HamburguesaPremium h3 = new HamburguesaPremium();
        h3.Mostrar();
    }
}
