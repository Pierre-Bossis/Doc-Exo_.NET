using algo.GestionStock;

Article article1 = new(1,"Pomme",1.99,3);
Article article2 = new(2,"Poire",2.99,5);
Article article3 = new(3,"Abricot",3.99,2);
Article article4 = new(4,"Fraise",1.99,6);
Article article5 = new(5,"Mangue",1.45,7);
Article article6 = new(6,"Tomate",0.99,4);
Article article7 = new(7,"Aubergine",3.55,3);
Article article8 = new(8,"Courgette",4.20,5);

List<Article> articles = new();

articles.Add(article1);
articles.Add(article2);
articles.Add(article3);  
articles.Add(article4);
articles.Add(article5);
articles.Add(article6);
articles.Add(article7);
articles.Add(article8);

Console.WriteLine("1.Rechercher un article par référence");
Console.WriteLine("2.Ajouter un article au stock en vérifiant l’unicité de la référence.");
Console.WriteLine("3.Supprimer un article par référence.");
Console.WriteLine("4.Modifier un article par référence.");
Console.WriteLine("5.Rechercher un article par nom.");
Console.WriteLine("6.Rechercher un article par intervalle de prix de vente.");
Console.WriteLine("7.Afficher tous les articles.");
Console.WriteLine("8.Quitter");

int input = int.Parse(Console.ReadLine());

switch (input)
{
	case 1:
        Console.WriteLine("Entrez la référence");
		int reference = int.Parse(Console.ReadLine());
		Article a = articles.Find(x => x.Reference == reference);
		Console.WriteLine(a.Nom);
		break;
	case 2:
        Console.WriteLine("Ajoutez un article.");
        Console.WriteLine("Numéro de référence");

		int numRef = int.Parse(Console.ReadLine()); ;
        while (articles.Find(x => x.Reference == numRef) is not null)
		{
            Console.WriteLine("Réference déjà existante.");
            numRef = int.Parse(Console.ReadLine());
		}
        Console.WriteLine("Nom");
		string nom = Console.ReadLine();
        Console.WriteLine("Prix");
		double prix = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantité stock");
		int quantite = int.Parse(Console.ReadLine());
		Article newArt = new(numRef, nom, prix, quantite);
		Console.WriteLine("Article ajouté.");
        break;
	case 3:
        Console.WriteLine("Entrez la référence à supprimer.");
		int entry = int.Parse(Console.ReadLine());
		Article ar = articles.Find(x => x.Reference == entry);
        Console.WriteLine(ar.Nom + " a bien été supprimé.");
        articles.Remove(ar);
        break;
	case 4:
        Console.WriteLine("Entrez la référence à modifier.");
        entry = int.Parse(Console.ReadLine());
        ar = articles.Find(x => x.Reference == entry);
        Console.WriteLine(ar.Nom + " trouvé. que souhaitez vous modifier ? nom(1),prix(2),quantité stock(3)");
		entry = int.Parse(Console.ReadLine());

		if(entry == 1)
		{
            Console.WriteLine("Entre le nouveau nom");
			ar.Nom = Console.ReadLine();
            Console.WriteLine("terminé.");
        }
		else if(entry == 2)
		{
            Console.WriteLine("Entrez le nouveau prix");
			ar.Prix = double.Parse(Console.ReadLine());
            Console.WriteLine("terminé.");
        }
		else if(entry == 3)
		{
            Console.WriteLine("Entrez la nouvelle quantité");
			ar.QuantiteStock = int.Parse(Console.ReadLine());
            Console.WriteLine("Terminé");
        }
        break;
	case 5:
        Console.WriteLine("Recherchez un article par nom.");
		nom = Console.ReadLine();
		ar = articles.Find(x => x.Nom == nom);
        Console.WriteLine(ar.Reference + " " + ar.Nom + " " + ar.Prix + " " + ar.QuantiteStock);
        break;
	case 6:
        Console.WriteLine("Recherchez un article par intervalle de prix");
        Console.WriteLine("Premier prix");
        double petit = double.Parse(Console.ReadLine());
        Console.WriteLine("Deuxième prix");
        double grand = double.Parse(Console.ReadLine());

		List<Article> list =  articles.FindAll(x => x.Prix >= petit && x.Prix <= grand);
		foreach (var item in list)
		{
            Console.WriteLine(item.Nom + " " + item.Prix);
        }
        break;
	case 7:
		foreach (var item in articles)
		{
            Console.WriteLine(item.Nom);
        }
		break;
	case 8:
		break;
	default:
		return;
}