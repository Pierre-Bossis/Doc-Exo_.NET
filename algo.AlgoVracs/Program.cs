using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace algo.AlgoVracs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multiplier un char
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}


            //valeur absolue
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //    number = number *- 1;
            //Console.WriteLine(number);

            //double val1 = double.Parse(Console.ReadLine());
            //double val2 = double.Parse(Console.ReadLine());
            //double val3 = double.Parse(Console.ReadLine());

            //List<int> list = new List<int>() { val1,val2,val3};
            //Console.WriteLine(list.Average());
            //ou
            //Console.WriteLine((val1 + val2 + val3)/3);

            //Exercice 11
            //Le centre de photocopie facture 0,25 DH pour les 10 premières photocopies, 0,20 DH les vingt suivantes et 0,10 DH au-delà.
            //Ecrire un algorithme qui demande à l’utilisateur de saisir le nombre de photocopies effectuées et qui affiche la facture correspondante.
            //Console.WriteLine("Entrez un nombre de photocopies");
            //int number = int.Parse(Console.ReadLine());
            //double prix = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i > 0 && i < 11)
            //        prix += 0.25;
            //    else if (i > 10 && i < 31)
            //        prix += 0.20;
            //    else
            //        prix += 0.10;
            //}
            //if (number == 1)
            //    prix = 0.25;
            //Console.WriteLine(Math.Round(prix,2));

            //Exercice 13
            //Écrire un algorithme permettant d’afficher le mois en lettre selon le numéro saisi au clavier.
            //(Si l’utilisateur tape 1 le programme affiche janvier, si 2  affiche  février, si 3 affiche mars...)

            //int mois = int.Parse(Console.ReadLine());
            //if(mois > 0 && mois < 13)
            //{
            //    string[] months = new string[] {"janvier","fevrier","mars","avril","mai","juin","juillet","aout","septembre","octobre","novembre","decembre"};
            //    Console.WriteLine(months[mois-1]);
            //}

            //Exercice 20
            //Écrire un algorithme qui permet d'afficher la table de multiplication de 5. Utilisant la boucle Pour.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i * 5);
            //}

            //Exercice 34
            //Ecrire un algorithme qui permet d'afficher  un  triangle  d'entiers, selon un entier saisi par l'utilisateur.
            //Exemple N=4 1 22 333 4444

            //int entier = int.Parse(Console.ReadLine());
            //int j = 0;
            //for (int i = 1; i <= entier; i++)
            //{
            //    while(j < i)
            //    {
            //        Console.Write(i);
            //        j++;
            //    }
            //    Console.WriteLine();
            //    j = 0;
            //}

            //Exercice 35
            //Écrire un algorithme qui permet de calculer le nombre de chiffres d'un entier N saisi  par l'utilisateur.
            //Exemple N = 10843 le nombre de chiffres est: 5

            //int number = int.Parse(Console.ReadLine());
            //string s = number.ToString();
            //int count = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);

            //Exercice 37
            //Écrire un algorithme qui permet de saisir un entier N et d'afficher le triangle d'étoiles.par exemple  N = 4
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    if(i==0)
            //        Console.WriteLine("*");
            //    else
            //    {
            //    string s = string.Join("", Enumerable.Repeat("*", i+2));
            //    Console.WriteLine(s);
            //    }
            //}

            ExosFunction exo = new();

            //exo52
            //Console.WriteLine(exo.Calcul(16, 12));

            //exo 57
            //exo.TableMultiplication(8);

            //exo 58
            //Console.WriteLine(exo.PGCD(221, 782));
        }
    }

    class ExosFunction()
    {
        //Exercice 52
        //Écrire une fonction qui permet de calculer le prix TTC, cette fonction va recevoir un paramètre de type Réel dont
        //le nom est "prixHT" et un second paramètre de type Réel dont le nom est "tva".
        //public double Calcul(double prixHT, double tva)
        //{
        //    double res = prixHT / 100 * tva;
        //    res += prixHT;

        //    return res;
        //}

        //Exercice 57
        //Ecrire une  procédure qui affiche le tableau de multiplication d’un entier positif x.
        //public void TableMultiplication(int number)
        //{
        //    for(int i = 1; i <= 10;i++)
        //    {
        //        Console.WriteLine(i*number);
        //    }
        //}

        //Exercice 58
        //Ecrire une fonction qui calcule le PGCD de deux entiers strictement positifs.
        //public int PGCD(int number1, int number2)
        //{
        //    List<int> PGCD1 = new();
        //    List<int> PGCD2 = new();

        //    for (int i = 1; i <= number1; i++)
        //    {
        //        if (number1 % i == 0)
        //            PGCD1.Add(i);
        //    }

        //    for (int i = 1;i <= number2; i++)
        //    {
        //        if (number2 % i == 0)
        //            PGCD2.Add(i);
        //    }

        //    PGCD1 = PGCD1.Reverse<int>().ToList();
        //    PGCD2 = PGCD2.Reverse<int>().ToList();

        //    for(int i = 0; i < PGCD1.Count;i++)
        //    {
        //        for (int j = 0; j < PGCD2.Count;j++)
        //        {
        //            if (PGCD1[i] == PGCD2[j])
        //                return PGCD1[i];
        //        }
        //    }
        //    return 0;
        //}


    }
}
