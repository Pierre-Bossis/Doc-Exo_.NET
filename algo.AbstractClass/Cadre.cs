using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.AbstractClass
{
    internal class Cadre : Employe
    {
        private int Indice { get; set; }
        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
        }

        public override double GetSalaire()
        {
            switch (Indice)
            {
                case 1:
                    return 13000;
                case 2:
                    return 15000;
                case 3:
                    return 17000;
                case 4:
                    return 20000;
                default:
                    return 0;
            }
        }
    }
}
