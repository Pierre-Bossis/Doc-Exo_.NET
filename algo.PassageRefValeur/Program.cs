namespace algo.PassageRefValeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int compteur = 10;

            Console.WriteLine("Compteur avant methode: " + compteur);

            /* ----- démo base passage par valeur ----- */
            //PassageRef(compteur);
            //compteur est toujours égal a 10 car c'est un passage pas valeur
            //Console.WriteLine("Compteur après méthode: " + compteur);

            /* ----- solution 1: réassigner ----- */
            //compteur =  PassageRef(compteur);
            //Console.WriteLine("Compteur après réassignation: " + compteur);

            /* ----- solution 2: passage avec mot clé ref ----- */
            Console.WriteLine(PassageRef(ref compteur));
            Console.WriteLine("Compteur après passage mot clé ref: " + compteur);

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            PassageOut(out int a);
            Console.WriteLine(a);
        }

        /* ----- REF ----- */
        //Permet de passer un argument par référence, modifiant la variable originale
        //optionnel: + retourner un booléen ou autre chose qu'on traitera ultérieurement (void possible aussi si on veut juste ne rien retourner)
        public static string PassageRef(ref int val)
        {

            val = 0;

            return "c'est passé !";
        }

        /* ----- OUT ----- */
        //Utilisé pour retourner plusieurs valeurs à partir d'une méthode. Il oblige la méthode à initialiser la variable avant de sortir.
        public static void PassageOut(out int a)
        {
            a = 20;
        }
    }
}
