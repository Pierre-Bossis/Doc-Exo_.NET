namespace algo.AbstractClass
{
    internal class Patron : Employe
    {
        public static double ChiffreAffaire { get; set; }
        private double Pourcentage { get; set; }
        public Patron(string matricule, string nom, string prenom, DateTime dateNaissance, double chiffreAffaire, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            ChiffreAffaire = chiffreAffaire;
            Pourcentage = pourcentage;
        }

        public override double GetSalaire()
        {
            double salaireAnnuel = ChiffreAffaire * Pourcentage / 100;
            return salaireAnnuel / 12;
        }
    }
}
