int[] tab1 = new int[8] { 1, 5, 4, 78, 9, 5, 4, 8 };
int[] tab2 = new int[8] {9,88,74,5,4,8,4,1 };

List<int> list = new();

for (int i = 0; i < tab1.Length; i++)
{
	for (int j = 0; j < tab2.Length; j++)
	{
		if (tab1[i] == tab2[j])
		{
			if (!list.Contains(tab1[i]))
			{
				list.Add(tab1[i]);
				break;
			}
		}
	}
}
list.Sort();
int[] tab3 = new int[list.Count];
tab3 = list.ToArray();

Console.WriteLine("longueur du tableau: " + tab3.Length);
foreach (int i in tab3)
{
    Console.WriteLine(i);
}