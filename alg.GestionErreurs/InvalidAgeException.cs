using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.GestionErreurs
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("L’âge doit être entre 18 et 26.");
        }
    }
}
