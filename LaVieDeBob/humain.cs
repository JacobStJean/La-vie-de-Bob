public class humain
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }



    public humain(string nom, string prenom, int age)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
    }
}
