class Program
{
    static void Main(string[] args)
    {
        DayCollection week = new ();

        Console.WriteLine(week.days.Length);

        int firstDayIndex = week["Lundi"];
        Console.WriteLine(firstDayIndex);
        string firstDayName = week[firstDayIndex];
        Console.WriteLine(firstDayName);
    }


}

public class DayCollection
{
    public string[] days = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

    public int this[string day] => FindDayIndex(day);
    public string this[int index]
    {
        get { return days[index]; } 
    } 

    private int FindDayIndex(string day)
    {
        for (int i = 0; i < days.Length; i++)
        {
            if (days[i] == day)
            {
                return i;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(day), $"Le jour {day} n'existe pas dans cette collection.");
    }
}