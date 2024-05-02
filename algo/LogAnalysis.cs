using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    public static class LogAnalysis
    {
        public static string SubstringAfter(this string str)
        {
            int position = str.IndexOf(": ");

            if ( position != -1)
            {
                string res = str.Substring(position + 2);
                return res;
            }
            else
            {
                return "pas été trouvé dans la chaîne.";
            }
        }

        public static string SubstringBetween(this string str,string first, string second)
        {
            string newStr = LogLevel(str);

            int index1 = newStr.IndexOf(first);
            int index2 = newStr.IndexOf(second);
            newStr = newStr.Remove(index2, 1);
            newStr = newStr.Remove(index1, 1);

            return newStr;
        }

        public static string Message(this string str)
        {
            return SubstringAfter(str);
        }


        public static string LogLevel(this string str)
        {
            int position = str.IndexOf(": ");
            int ToRemove = str.Length - position;

            string res = str.Remove(position, ToRemove);

            return res;
        }
    }
}
