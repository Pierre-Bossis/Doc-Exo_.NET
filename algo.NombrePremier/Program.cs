Console.WriteLine("Entrez un nombre pour voir si c'est un nombre premier");

int entry = int.Parse(Console.ReadLine());
bool result = true;

for (int i = 2; i < entry; i++)
{
    if(entry % i == 0)
    {
        result = false;
        break;
    }
}

if (!result)
{
    Console.WriteLine("Ce n'en est pas un.");
}

else
{
    Console.WriteLine("c'est un nombre premier.");
}