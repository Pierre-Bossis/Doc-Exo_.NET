class Program
{
    static void Main(string[] args)
    {
        Solution sol = new();

        int nbConverted = sol.RomanToInt("IX");

        Console.WriteLine(nbConverted);
    }

}
public class Solution
{
    public int RomanToInt(string s)
    {
        int res = 0;

        for (int i = 0; i < s.Length; i++)
        {
            //si i n'as pas atteint la taille du tableau et que char 1 est plus petit que celui qui le suit
            if (i < s.Length - 1 && RomanValue(s[i]) < RomanValue(s[i + 1]))
            {
                res -= RomanValue(s[i]);
            }
            //sinon on ajoute juste
            else
            {
                res += RomanValue(s[i]);
            }
        }
        return res;
    }

    private int RomanValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
