using _4_Generics.Finish;
using Capacitacion.Finish;
using System;

namespace _4_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultString = new GenericClass<string>().GetDefault();
            var defaultDatetime = new GenericClass<DateTime>().GetDefault();
            Console.WriteLine(defaultString);
            Console.WriteLine(defaultDatetime);

            var userGeneric = new GenericEntity<User>();
            var productGeneric = new GenericEntity<Product>();

            Console.ReadKey();
        }
    }
}
