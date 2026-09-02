namespace Animal;
public abstract class Animal
{

    public string Nom { get; set; }
    public bool AFaim { get; set; }
    public DateTime DernierRepas { get; set; }
    public double CoutRepas { get; set; }
    public int DelaiRepas { get; set; }

    // Constructeur corrigé
    public Animal(string nom, bool aFaim, DateTime dernierRepas, double coutRepas, int delaiRepas)
    {
        Nom = nom;
        AFaim = aFaim;
        DernierRepas = dernierRepas;
        CoutRepas = coutRepas;
        DelaiRepas = delaiRepas;
    }

    // Méthodes prêtes pour l'héritage
    public virtual void Exprimer()
    {
    }

    public virtual void Manger(DateTime date)
    {
    }

    public virtual bool PeutManger(DateTime date)
    {

        return false;
    }
}
