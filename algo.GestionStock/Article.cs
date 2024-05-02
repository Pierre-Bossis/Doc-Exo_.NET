using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.GestionStock
{
    internal class Article
    {
        public int Reference { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int QuantiteStock { get; set; }

        public Article(int reference,string nom,double prix,int quantiteStock)
        {
            Reference = reference;
            Nom = nom;
            Prix = prix;
            QuantiteStock = quantiteStock;
        }

        public string ToString(int s)
        {
            return s.ToString();
        }
    }
}
