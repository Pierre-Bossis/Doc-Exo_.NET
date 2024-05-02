Console.WriteLine("Entrez un nombre");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez sa puissance");
int puissance = int.Parse(Console.ReadLine());

int res = 0;

if (puissance != 1)
{
    for (int i = 1; i < puissance; i++)
    {
        if (i == 1)
            res += number * number;
        else
            res *= number;
    }
}

Console.WriteLine();
Console.WriteLine(res);

