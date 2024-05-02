using algo.CompteBancaire;

int CompteurCode = 1;

Compte compte = new(CompteurCode);
CompteurCode++;

compte.Depot(3000);
compte.ConsulterSolde();

CompteEpargne compte2 = new(CompteurCode,3000);
CompteurCode++;
compte2.calculInteret();

Console.WriteLine(compte.Code);
Console.WriteLine(compte2.Code);