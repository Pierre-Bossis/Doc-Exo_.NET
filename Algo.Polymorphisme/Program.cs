using Algo.Polymorphisme;


Personne[] tab = new Personne[8]
{
     new Employe("Bossis", "Pierre", new DateTime(1994, 11, 14), 1800),
     new Employe("Bossis", "Nicolas", new DateTime(1994, 11, 14), 1850),
     new Employe("Bossis", "Caroline", new DateTime(1993, 03, 21), 1750),
     new Employe("Abela", "Ivan", new DateTime(1995, 03, 05), 2500),
     new Employe("Dupont", "Jean", new DateTime(1980, 05, 25), 1950),
     new Chef("NomChef1", "PrenomChef1", DateTime.Now, 2800, "Ressources humaines"),
     new Chef("NomChef2", "PrenomChef", DateTime.Now, 2800, "Marketing"),
     new Directeur("NomDirecteur1", "PrenomDirecteur1", DateTime.Now, 4500, "Delhaize")
};

//for (int i = 0; i < tab.Length; i++)
//{
//    tab[i].Afficher();
//}

foreach (Personne person in tab)
{
    Console.WriteLine(person.GetType().Name);
    person.Afficher();
    Console.WriteLine();
}