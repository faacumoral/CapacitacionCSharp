using System;

namespace _5_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Id = 1,
                Name = "Facundo"
            };

            #region Reflection
            foreach (var p in user.GetType().GetProperties())
            {
                Console.WriteLine($"{p.Name} = {p.GetValue(user)}"); 
            }
            Console.ReadKey();
            #endregion
        }
    }
}
