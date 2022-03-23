// See https://aka.ms/new-console-template for more information

using Models;

Personne personne = new Personne()
{
    Nom = "Person",
    Prenom = "Michael",
    BirthDate = new DateTime(1981, 03, 17)
};

Courant courant = new Courant()
{
    Numero = "000001",
    Titulaire = personne,
    LigneDeCredit = 500
};

Epargne epargne = new Epargne()
{
    Numero = "000002",
    Titulaire = personne,
};

courant.Depot(500);
epargne.Depot(500);
courant.Retrait(700);
epargne.Retrait(100);
Console.WriteLine(courant.Solde);


