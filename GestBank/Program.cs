// See https://aka.ms/new-console-template for more information

using Models;

List<Courant> comptes = new List<Courant>();

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

Courant courant2 = new Courant()
{
    Numero = "000002",
    Titulaire = personne,
    LigneDeCredit = 500
};

courant.Depot(500);
courant2.Depot(500);
courant.Retrait(700);
Console.WriteLine(courant.Solde);

comptes.Add(courant);
comptes.Add(courant2);

