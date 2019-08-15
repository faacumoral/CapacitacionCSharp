using Capacitacion.Finish;
using System;

namespace Capacitacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultString = new GenericClass<string>().GetDefault();
            var defaultDatetime = new GenericClass<DateTime>().GetDefault();





            Console.WriteLine(defaultString);
            Console.WriteLine(defaultDatetime);

            Console.ReadKey();
        }
    }
}
