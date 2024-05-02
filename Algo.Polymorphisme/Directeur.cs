using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Polymorphisme
{
    internal class Directeur : Chef
    {
        private string Societe {  get; set; }
        public Directeur(string nom, string prenom, DateTime dateNaissance, double salaire, string societe) : base(nom, prenom, dateNaissance, salaire)
        {
            Societe = societe;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Société: " + Societe);
        }
    }
}
