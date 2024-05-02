namespace algo.AbstractClass
{
    internal class Ouvrier : Employe
    {
        private DateTime DateEntree { get; set; }
        public static double SMIG = 2500;
        public Ouvrier(string matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEntree) : base(matricule, nom, prenom, dateNaissance)
        {
            DateEntree = dateEntree;
        }

        public override double GetSalaire()
        {
            double salaire = SMIG + (DateTime.Now.Year - DateEntree.Year)*100;
            if (salaire > SMIG*2)
                salaire = SMIG*2;
            return salaire;
        }
    }
}
