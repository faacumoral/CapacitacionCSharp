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

    }
}
