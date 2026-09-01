classDiagram

class Humain
{
    +string Nom
    +Compte Compte
    +deposerArgent(double montant)
    +retirerArgent(double montant)
}

class Programmeur
{
    +double SalaireHoraire
    +travailler(double heures)
    +nourrirAnimal(Animal animal)
}

class Compte
{
    +double Solde
    +deposer(double montant)
    +retirer(double montant)
}

class Animal
{
    <<abstract>>
    +string Nom
    +bool A_Faim
    +DateTime DernierRepas
    +double CoutRepas
    +int DelaiRepas
    +exprimer()
    +manger(DateTime date)
    +peutManger(DateTime date)
}

class Chat
{
    +exprimer()
}

class Chien
{
    +exprimer()
}

class Horloge
{
    +DateTime DateActuelle
    +avancerTemps(double heures)
}

Humain <| --Programmeur
Animal <| --Chat
Animal <| --Chien

Humain "1" *-- "1" Compte : possède

Programmeur "1"-- > "1" Chat : possède
Programmeur "1"-- > "1" Chien : possède

Programmeur --> Horloge : utilise
Animal --> Horloge : utilise


