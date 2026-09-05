namespace LaVieDeBob;

public record struct Emploi
{
    public string Titre { get; set; }
    public decimal Salaire { get; set; }

    public Emploi(string titre, decimal salaire)
    {
        Titre = titre;
        Salaire = salaire;
    }
}


