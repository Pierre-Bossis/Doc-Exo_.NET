using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.GestionErreurs
{
    internal class InvalidNoteException : Exception
    {
        public override string Message
        {
            get
            {
                return "la note doit être entre 0 et 20";
            }
        }
        public InvalidNoteException(): base()
        {
            
        }
    }
}
