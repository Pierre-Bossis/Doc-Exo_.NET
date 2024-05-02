int[] tab = new int[10] { 9, 5, 11, 89, 1, 59, 799, 187, 3, 97 };

for (int i = 0; i < tab.Length; i++)
{
    for (int j = i+1; j < tab.Length; j++)
    {
        if (tab[j] < tab[i])
        {
            int temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }
    }
    Console.Write("["+tab[i]+"]");
}