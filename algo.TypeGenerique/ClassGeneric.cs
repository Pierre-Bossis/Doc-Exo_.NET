using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.TypeGenerique
{
    public class ClassGeneric<T>  //where T : struct pour forcer le type entré a être uniquement une struct (int32), string est une class.
    {
        public T One { get; set; }
        public T Two { get; set; }

        public ClassGeneric(T one, T two)
        {
            One = one;
            Two = two;
        }

        public T Sum()
        {
            dynamic one = One;
            dynamic two = Two;
            return one + two;
        }
        public override string ToString()
        {
            return $"{One} et {Two} sont de type {One.GetType().Name}";
        }
    }
}
