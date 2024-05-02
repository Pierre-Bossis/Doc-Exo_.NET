using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.IsPalindrome(-505)); 
    }
}

static class Solution
{
    public static bool IsPalindrome(int x)
    {
        bool isPal = false;

        string chaine = x.ToString();
        if (chaine.Length == 1)
            isPal = true;

        else
        {
            string chaine2 = "";
            List<char> charArray = new();
            charArray = chaine.Reverse().ToList();
            foreach (char c in charArray)
            {
                chaine2 += c;
            }

            if(chaine == chaine2)
            {
                isPal = true;
            }
        }

        return isPal;
    }
}