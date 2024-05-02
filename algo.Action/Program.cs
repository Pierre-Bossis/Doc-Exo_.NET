class Program
{
    static void Main(string[] args)
    {
        //Action ne renvoie rien
        //Func renvoie quelque chose

        Recepteur recepteur = new();
        Emetteur emetteur = new();

        //----------Action----------

        //on rajoute ReceptAction comme étant abonné à l'event MyAction
        emetteur.MyAction += recepteur.ReceptAction;

        //on execute la méthode qui va déclencher l'event MyAction
        emetteur.EmetteurAction();

        //----------func----------

        //on rajoute ReceptFunc comme étant abonné à l'event MyFunc
        emetteur.MyFunc += recepteur.ReceptFunc;

        //on execute la méthode qui va déclencher l'event MyFunc
        emetteur.EmetteurFunc();
    }
}
public class Recepteur
{
    public void ReceptAction(string s)
    {
        //receptionne le message de EmetteurAction par le biais de l'event MyAction
        Console.WriteLine(s);
    }

    public int ReceptFunc(int numb1, int numb2)
    {
        //receptionne le numb1 et numb2 de EmetteurFunc par le biais de l'event MyFunc
        return numb1 * numb2;
    }
}
public class Emetteur
{
    public event Action<string> MyAction = null;

    public event Func<int, int, int> MyFunc = null;

    public void EmetteurAction()
    {
        if (MyAction != null)
        {
            //déclencheur de l'event MyAction qui passe le message en paramètre à l'abonné, ReceptAction ici
            MyAction.Invoke("mon message envoyé en paramètre");
        }
    }

    public void EmetteurFunc()
    {
        if (MyFunc != null)
        {
            //déclencheur de l'event MyFunc qui passe 4 et 5 en paramètre à l'abonné, ReceptFunc ici
            Console.WriteLine(MyFunc.Invoke(4, 5));
        }
    }
}