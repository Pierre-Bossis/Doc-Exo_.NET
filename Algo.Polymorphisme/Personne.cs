using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Polymorphisme
{
    internal class Personne
    {
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private DateTime DateNaissance { get; set; }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine(Nom + " " + Prenom + " né le" + DateNaissance);
        }
    }
}
