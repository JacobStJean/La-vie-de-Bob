namespace LaVieDeBob;

    public class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public Emploi Emploi { get; }
        public Compte Compte { get; }


        public Personne(string prenom, string nom, string titreEmploi, decimal salaire)
        {
            Prenom = prenom;
            Nom = nom;
            Emploi = new(titreEmploi, salaire);
            Compte = new Compte();
        }

        public Personne(string prenom) : this(prenom, "", "Sans emploi", 0)
        { }

        public Personne(string prenom, string emploi, decimal salaire) : this(prenom, "", emploi, salaire)
        { }


        public decimal Travailler(int heures)
        {
            if (heures < 0)
                throw new ArgumentOutOfRangeException("Le nombre d'heures travaillées doit être positif.");

            decimal salaireGagne = heures * Emploi.Salaire;
            Compte.Deposer(salaireGagne);

            return salaireGagne;
        }


        public decimal Nourrir(DateTime heureRepas)
        {
            // TODO: nourrir l'animal et retirer le montant du repas du compte bancaire
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Salut! Je m'appelle {Prenom} {Nom}. " +
                   $"Je suis {Emploi.Titre} et je gagne " +
                   $"{Emploi.Salaire:C}/h";
        }
    }
