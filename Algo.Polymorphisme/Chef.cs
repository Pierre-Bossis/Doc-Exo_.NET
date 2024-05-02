using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Polymorphisme
{
    internal class Chef : Employe
    {
        private string Service { get; set; }
        public Chef(string nom, string prenom, DateTime dateNaissance, double salaire, string service) : base(nom, prenom, dateNaissance, salaire)
        {
            Service = service;
        }


        public Chef(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance, salaire)
        {
        }

        public override void Afficher()
        {
            base.Afficher();
            if(Service is not null)
                Console.WriteLine("Service: " + Service);
        }
    }
}
