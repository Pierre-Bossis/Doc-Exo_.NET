using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.CompteBancaire
{
    public class Compte
    {
        public int Code { get; private set; }
        protected double Solde { get; set; }

        public Compte(int code, double solde = 0)
        {
            Code = code;
            Solde = solde;
        }

        public void Depot(double montant)
        {
            Solde += montant;
            Console.WriteLine($"{montant} euros a bien été déposé sur le compte {Code}");
        }

        public void Retrait(double montant)
        {
            Solde -= montant;
            Console.WriteLine($"{montant} euros a bien été retiré du compte {Code}");
        }

        public void ConsulterSolde()
        {
            Console.WriteLine($"Le solde du compte {Code} est de {Solde}");
        }
    }
}
