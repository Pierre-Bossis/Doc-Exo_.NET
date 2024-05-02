Console.WriteLine("Entrez un nombre");

int input = int.Parse(Console.ReadLine());
int[] tab = new int[input];
int res = 1;

for (int i = 0; i < input; i++)
{
    res *= i+1;
}

Console.WriteLine("la factorielle de " + input + " est : " + res);