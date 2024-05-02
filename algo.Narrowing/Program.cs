namespace algo.Narrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TraiterValeur("yo");
        }

        //bcp plus proche du concept en angular:  valeur: string | number, angular sait que si c'est pas un string, c'est un number
        public static void TraiterValeur(object valeur)
        {
            if (valeur is int intValue)
            {
                Console.WriteLine($"Type reconnu: {intValue.GetType().Name} -> {intValue+5}");
            }
            else if (valeur is double doubleValue)
            {
                Console.WriteLine($"Type reconnu: {doubleValue.GetType().Name} -> {doubleValue + 5.55}");
            }
            else if (valeur is string stringValue)
            {
                Console.WriteLine($"Type reconnu: {stringValue.GetType().Name} -> {stringValue + 5}");
            }
            else
            {
                Console.WriteLine("Type inconnu");
            }
        }
    }
}