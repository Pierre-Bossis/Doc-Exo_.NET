using System.Runtime.ConstrainedExecution;
using System;
using System.Text;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace algo.AlgosGameCodeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exo1
            //Créer deux variables de type chaîne de caractère puis créer une troisième 
            //variable contenant les 2 variables concaténées, avec un espace entre les 2
            //○ Exemple: Variable 1 "Jean", Variable 2 "Michel", la variable 3 devra contenir "Jean Michel"
            //string a = "hello";
            //string b = "bonjour";
            //string c = a + " " + b;
            //Console.WriteLine(c);

            //exo2
            // Créer deux variables numériques de valeurs quelconques ou aléatoires, puis 
            //une condition qui affiche si la première est égale, supérieure ou inférieure à la
            //seconde
            //○ Exemple: Variable 1 : 100, Variable 2 : 50->La condition affiche "la valeur 1 et supérieure"
            //Random random = new Random();
            //int a = random.Next(1, 20);
            //int b = random.Next(1, 20);
            //if(a > b)
            //    Console.WriteLine($"{a} est supérieur à {b}");
            //if(a ==b )
            //    Console.WriteLine($"{a} et {b} sont identique.");
            //if (a < b )
            //    Console.WriteLine($"{a} est inférieur à {b}");
            exos exo = new();

            //exo5
            //Console.WriteLine(exo.calcul(1,5));

            //exo6
            //Console.WriteLine(exo.calculIMC(85,1.80));

            //exo7
            //int[] tab = exo.calcul(1,66);
            //foreach(int i in tab)
            //{
            //    Console.WriteLine(i);
            //}

            //exo8
            //Console.WriteLine(exo.ChiffreEnLettre(5));

            //exo10
            //Console.WriteLine(exo.CalculPourboire(50,2));

            /* ---------- Boucles ---------- */

            //exo 11
            //Créer une boucle qui affiche (avec print) les valeurs de 0 à 100
            //for (int i = 1;i <= 100;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //exo12
            // Créer une boucle qui affiche les valeurs de 100 à 0
            //for (int i = 100; i > 0;i--)
            //{
            //    Console.WriteLine(i);
            //}

            //exo13
            // Créer une boucle qui affiche les valeurs de 1 à 99, uniquement les nombres impairs: 1,3,5,7…
            //for (int i = 1; i < 100; i++)
            //    {
            //        if(i % 2 != 0)
            //            Console.WriteLine(i);
            //    }

            //exo14
            //Créer une boucle qui affiche les multiples de 10(jusqu'à 1000) : 10,20,30,...
            //for (int i = 10; i <= 1000; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            //exo15
            //Console.WriteLine(exo.CalculTable(6));
            //Console.WriteLine(exo.calcul(new List<int> { 1,5,6,78,11,4484}));

            //exo 17
            //List<int> list = exo.ReverseList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //exo18
            //Créer une boucle pour créer une liste de 100 valeurs aléatoires entre 0 et 1000, mais une même valeur ne doit pas s'y trouver 2 fois
            //List<int> list = new();
            //Random rand = new Random();
            //while(list.Count < 101)
            //{
            //    int number = rand.Next(0,1000);
            //    if(!list.Contains(number))
            //        list.Add(number);
            //}
            //foreach(int number in list)
            //{
            //    Console.WriteLine(number);
            //}
            //List<int> list = new();
            //list = exo.Supprime(new List<int> { 1,2,3,400,5,4,8,9,600,1,2,4},400,600);
            //foreach(int i in list)
            //    Console.WriteLine(i);

            //tableau 2 dimensions
            int[,] Tab2Dim = new int[10,10];
            int count = 1;
            for (int i = 0; i < Tab2Dim.GetLength(0); i++)
            {
                for (int j = 0; j < Tab2Dim.GetLength(1); j++)
                {
                    Tab2Dim[i,j] = count;
                    count++;
                }
            }
            for (int i = 0; i < Tab2Dim.GetLength(0); i++)
            {
                for (int j = 0; j < Tab2Dim.GetLength(1); j++)
                {
                    Console.WriteLine(Tab2Dim[i, j]);
                }
            }

        }
        class exos
        {
            /* ----------Fonctions---------- */

            //exo 16
            //Programmer une fonction qui retourne la valeur la plus élevée d'une liste
            //○ Ex : Reçoit {2, 58, 4, 645, 452, 57} -> Retourne 645
            //○ Variation : cherchez aussi la valeur la plus petite
            //public int calcul(List<int> list)
            //{
            //    int res = 0;
            //    //return list.Max();
            //    foreach(int i in list)
            //    {
            //        if(i > res)
            //            res = i;
            //    }
            //    return res;
            //}

            //exo17
            //Programmer une fonction qui retourne une liste dans son ordre inverse (sans utiliser de fonction de tri de Lua)
            //public List<int> ReverseList(List<int> liste)
            //{
            //    List<int> ListToReturn = new List<int>();

            //    for (int i = liste.Count -1; i > -1;i--)
            //    {
            //        ListToReturn.Add(liste[i]);
            //    }

            //    return ListToReturn;
            //}

            //exo19
            //Créer une fonction pour supprimer dans cette liste toutes les valeurs entre 2 bornes passées en paramètre et 
            //retourne une nouvelle liste.
            //○ Exemple : Supprime(400,600) -> Supprime toutes les valeurs entre 400 et 600 et retourne la nouvelle liste ne contenant que les autres
            //valeurs
            //public List<int> Supprime(List<int> list,int a,int b)
            //{
            //    int index1 = 0;
            //    int nbElem = 0;

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i] == a)
            //        {
            //            index1 = i;
            //        }    

            //        if (list[i] == b)
            //        {
            //            nbElem = i - index1 +1;
            //            break;
            //        }
            //    }
            //    list.RemoveRange(index1,nbElem);
            //    return list;
            //}

            // Créer une fonction qui ajoute une valeur à une liste :
            //○ Ex : Ajoute(liste, 10) -> Ajoute la valeur 10 à la liste



        }
    }
}
