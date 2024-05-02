namespace algo.MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new() { 1,2,4 };
            List<int> list2 = new() { 1,3,4 };

            List<int> list = new();

            list = list.Concat(list1).ToList();
            list = list.Concat(list2).ToList();

            list.Sort();


            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
