namespace LaVieDeBob;

public class Compte
{
    public decimal Solde { get; set; }


    public Compte(decimal soldeInitial = 0)
    {
        Solde = soldeInitial;
    }
    public void Deposer(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Le montant à déposer doit être positif.");
        }
    }

    public void Retirer(decimal montant)
    {
        if (montant > 0)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
            }
            else
            {
                throw new InvalidOperationException("Solde insuffisant.");
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException("Le montant à retirer doit être positif.");
        }
    }
}









