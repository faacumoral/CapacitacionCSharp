using Capacitacion.Finish;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Generics.Finish
{
    public class GenericEntity<T> where T : Entity
    {
        public void Do(T t)
        {
            var id = t.Id;
        }
    }
}
