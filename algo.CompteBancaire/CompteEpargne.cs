using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.CompteBancaire
{
    public class CompteEpargne : Compte
    {
        public CompteEpargne(int code, double solde = 0) : base(code, solde)
        {
        }

        public double TauxInteret { get; set; } = 6;

        public void calculInteret()
        {
            double diff = (Solde / 100) * TauxInteret;
            Console.WriteLine($"Compte {Code}: l'intérêt est de {diff} euros.");
        }
    }

}
