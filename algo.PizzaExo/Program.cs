//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Channels;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = Encoding.UTF8;

//        List<Pizza> list = new List<Pizza>()
//        {
//            new Pizza("4 fromages",11.5,true, new(){"ingredient1","ingredient2","tomate"}),
//            new Pizza("3 fromages",10.5,true, new(){"ingredient3","ingredient4","Tomate"}),
//            new("1 fromage",7,true, new(){"ingredient5","ingredient6","tomate"}),
//            new("Jambon",12,false, new(){"ingredient7","ingredient8"})
//        };

//        list = list.OrderBy(x => x.Prix).ToList();

//        foreach (Pizza pizz in list)
//        {
//            pizz.Afficher();
//        }

//        Console.WriteLine("Pizza la moins chère:");
//        Pizza pizzaMoinsChere = list.OrderBy(x => x.Prix).FirstOrDefault();
//        pizzaMoinsChere.Afficher();

//        Console.WriteLine("Pizza la plus chère:");
//        Pizza pizzaPlusChere = list.OrderByDescending(x => x.Prix).FirstOrDefault();
//        pizzaPlusChere.Afficher();

//        Console.WriteLine("Uniquement les végétarienne");
//        List<Pizza> listeVegetarienne = list.Where(x => x.IsVegetarienne == true).ToList();
//        foreach(Pizza pizza in listeVegetarienne)
//        {
//            pizza.Afficher();
//        }

//        Console.WriteLine("------------------------------------");
//        Console.WriteLine("Pizza qui contiennent de la tomate");
//        Console.WriteLine("------------------------------------");

//        List<Pizza> PizzaAvecTomate = list.Where(x => x.Ingredients.Contains("tomate")).ToList();
//        foreach (Pizza pizza in listeVegetarienne)
//        {
//            pizza.Afficher();
//        }
//    }
//}

//class Pizza
//{
//    public string Nom { get; set; }
//    public double Prix { get; set; }
//    public bool IsVegetarienne { get; set; }
//    public List<string> Ingredients { get; set; } = new();

//    public Pizza(string nom, double prix, bool isV, List<string> ingredients)
//    {
//        Nom = nom;
//        Prix = prix;
//        IsVegetarienne = isV;
//        Ingredients = ingredients;
//    }
//    public Pizza()
//    {

//    }

//    public void Afficher()
//    {
//        if (!string.IsNullOrEmpty(Nom))
//        {
//            string nomAffiché = Reformat(Nom);

//            Console.WriteLine(nomAffiché + (IsVegetarienne ? "(V) " : " ") + Prix + "€");
//            Console.WriteLine("Ingrédients:");

//            Console.WriteLine(string.Join(", ",Reformat(Ingredients)));
//            Console.WriteLine();
//            Console.WriteLine("-----------");
//            Console.WriteLine();
//        }
//    }

//    private string Reformat(string chaine)
//    {
//        string minuscule = chaine.ToLower();
//        string maj = chaine.ToUpper();

//        return maj[0] + minuscule[1..];
//    }

//    private List<string> Reformat(List<string> list)
//    {
//        List<string> ListeToReturn = new();

//        foreach (string ingredient in list)
//        {
//            string minuscule = ingredient.ToLower();
//            string maj = ingredient.ToUpper();

//            ListeToReturn.Add(maj[0] + minuscule[1..]);
//        }
//        return ListeToReturn;
//    }
//}

List<string> ListX1 = new();
List<string> ListX2 = new();
List<string> ListX3 = new();

List<string> ListY1 = new();
List<string> ListY2 = new();
List<string> ListY3 = new();

int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
for (int i = 0; i < height; i++)
{
    string line = Console.ReadLine(); // width characters, each either 0 or .

    if ((i == 0) && (line[0] == '0'))
    {
        ListX1.AddRange(
           new List<string>{
                        "0","0","1","0"
           }
       );
    }

    // if((i == 0) && (line[1] == '0')){
    //     ListX2.AddRange(
    //         new List<string>{
    //             "1","0","2","0"
    //         }
    //     );
    // }

    if ((i == 1) && (line[0] == '0'))
    {
        ListY1.AddRange(
            new List<string>{
                        "0","1"
            }
        );
    }
    //ListX1.AddRange(ListY1);
    Console.WriteLine(string.Join(" ", ListX1));

    foreach (var f in ListX1)
    {
        Console.Error.WriteLine(f);
    }
}