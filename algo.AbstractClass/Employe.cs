using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.AbstractClass
{
    internal abstract class Employe
    {
        public string Matricule { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        protected Employe(string matricule,string nom,string prenom,DateTime dateNaissance)
        {
            
        }

        public void Tostring()
        {

        }

        public abstract double GetSalaire();
    }
}
