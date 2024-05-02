using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Polymorphisme
{
    internal class Employe : Personne
    {
        private double Salaire { get; set; }
        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
        {
            Salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Salaire: " +Salaire);
        }
    }
}
