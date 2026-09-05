namespace LaVieDeBob;

public class Chat : Animal
{
    public string Race { get; set; }

    public Chat(string nom, bool aFaim, DateTime dernierRepas, double coutRepas, int delaiRepas, string race)
        : base(nom, aFaim, dernierRepas, coutRepas, delaiRepas)
    {
        Race = race;
    }
    public override void Exprimer()
    {
        Console.WriteLine("Miauw ! Miauw !");

    }
}
