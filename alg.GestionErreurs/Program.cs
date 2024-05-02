//Console.WriteLine("Saisissez un entier");

//bool b = int.TryParse(Console.ReadLine(), out int value);

//while (!b)
//{
//    Console.WriteLine("Format incorrect, réessayez.");
//    b = int.TryParse(Console.ReadLine(), out value);
//}

//Console.WriteLine("valeur : " + value);


// -----------------------------------------------------

//Console.WriteLine("Entrez votre date de naissance");

//bool b = DateTime.TryParse(Console.ReadLine(), out DateTime date);

//while (!b)
//{
//    Console.WriteLine("Format incorrect, réessayez.");
//    b = DateTime.TryParse(Console.ReadLine(), out date);
//}

//Console.WriteLine("Date : " + date.ToString("d M  yyyy"));

//--------------------------------------------------------------
//Console.WriteLine("Entrez une date de départ");
//DateTime date1 = DateTime.Parse(Console.ReadLine());
//Console.WriteLine("Entrez une date d'arrivée");
//DateTime date2 = DateTime.Parse(Console.ReadLine());

//long timestampSecond1 = (long)(date1 - new DateTime(1970, 1, 1)).TotalSeconds;
//long timestampSecond2 = (long)(date2 - new DateTime(1970, 1, 1)).TotalSeconds;

//if(timestampSecond2 > timestampSecond1)
//    Console.WriteLine("nice");
//else
//    Console.WriteLine("Pas bon");
using algo.GestionErreurs;

Eleve newEleve = new();

Console.WriteLine("entrez votre nom");
newEleve.Nom = Console.ReadLine();
Console.WriteLine("entrez votre age");
newEleve.Age = int.Parse(Console.ReadLine());
Console.WriteLine("entrez votre moyenne");
newEleve.Moyenne = double.Parse(Console.ReadLine());
