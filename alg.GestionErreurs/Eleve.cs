using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.GestionErreurs
{
    internal class Eleve
    {
        public string Nom { get; set; }
        private int _age { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 26 || value < 18)
                {
                    throw new InvalidAgeException();
                }
                else
                    _age = value;
            }
        }
        private double _moyenne { get; set; }
        public double Moyenne
        {
            get
            {
                return _moyenne;
            }
            set
            {
                if (value < 0 || value > 20)
                    throw new InvalidNoteException();
                else
                    _moyenne = value;
            }
        }

        public Eleve()
        {
        }
    }
}
