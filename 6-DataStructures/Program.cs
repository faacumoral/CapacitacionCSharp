using System;

namespace _6_DataStructures
{
    class Program
    {
        public struct User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class UserClass
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
        public struct UserStruct
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {
            var user = new User
            {
                Name = "Juan"
            };

            var user2 = user;
            user2.Name = "Facundo";
            Console.WriteLine(user.Name);


            Console.ReadKey();
        }
    }
}
