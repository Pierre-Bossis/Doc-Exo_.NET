Console.WriteLine("Entrez un mot");
string mot1 = Console.ReadLine();
Console.WriteLine("Entrez un deuxième mot");
string mot2 = Console.ReadLine();

char[] tab1 = mot1.ToCharArray();
char[] tab2 = mot2.ToCharArray();

string motCompose = "";

for (int i = 0; i < tab1.Length; i++)
{
    if (tab1.Length != tab2.Length)
    {
        break;
    }
        for (int j = 0; j < tab2.Length; j++)
    {
        if(tab2[j] == tab1[i])
        {
            motCompose += tab1[i];
            break;
        }
    }
}

if (mot1 == motCompose)
{
    Console.WriteLine("les mots sont bien anagramme");
}
else
{
    Console.WriteLine("ils ne le sont pas.");
}