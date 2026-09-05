namespace LaVieDeBob;

public class Chien : Animal
{
    public string Race { get; set; }

    public Chien(string nom, bool aFaim, DateTime dernierRepas, double coutRepas, int delaiRepas, string race)
        : base(nom, aFaim, dernierRepas, coutRepas, delaiRepas)
    {
        Race = race;
    }
    public override void Exprimer()
    {
        Console.WriteLine("Wouf ! Wouf !");

    }
}
