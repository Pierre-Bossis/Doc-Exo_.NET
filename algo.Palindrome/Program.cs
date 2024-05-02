Console.WriteLine("Entrez un mot pour voir si c'est un palindrome");

string chaine = Console.ReadLine();
string chaineReverse = "";

char[] tab = new char[chaine.Length];

for (int i = 0; i < chaine.Length; i++)
{
    tab[i] = chaine[i];
}

tab = tab.Reverse().ToArray();

for (int i = 0; i < tab.Length; i++)
{
    chaineReverse += tab[i];
}

Console.WriteLine("chaine initiale: " + chaine);
Console.WriteLine("chaine inversée: " + chaineReverse);

if (chaine.Equals(chaineReverse))
{
    Console.WriteLine();
    Console.WriteLine(chaine + " est bien un palindrome.");
}

else
    Console.WriteLine(chaine + " n'est pas un palindrome.");