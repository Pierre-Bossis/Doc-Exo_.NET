Console.WriteLine("Entrez un mot pour compter le nombre de voyelles");
string mot = Console.ReadLine();
int compteur = 0;

char[] Voyelles = new char[5] {'a','e','i','o','u'};

for (int i = 0; i < mot.Length; i++)
{
    for (int j = 0; j < Voyelles.Length; j++)
    {
        if (mot[i] == Voyelles[j])
        {
            compteur++;
            break;
        }
    }
}

Console.WriteLine(compteur +  (compteur > 1 ? " voyelles." : " voyelle."));

