using System;
using System.Collections.Generic;
using System.Text;

namespace Capacitacion.Finish
{
    public class GenericClass<T>
    {
        public T GetDefault()
        {
            return default(T);
        }

        public bool Compare(T one, T other)
        {
            return one.Equals(other);
        }

    }
}
