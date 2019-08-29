using System;

namespace _3_Lambdas
{
    #region Class and Interface
    public interface IUser
    {
        string SayHi();
    }

    public class User : IUser
    {
        public string Name { get; set; }
        public User(string pName)
        {
            Name = pName;
        }

        public string SayHi()
        {
            return "Hi!";
        }
    }
    #endregion

    #region Delegates
    public delegate string DelegateName(string str);
    #endregion

    class Program
    {
        
        static void Main(string[] args)
        {
            IUser user;
            user = new User("Facundo");
            user.SayHi();

            DelegateName del;
            del = Method;
            del("string");


            #region Func

            #endregion
        }


        public static string Method(string str)
        {
            return str.Trim();
        }
    }
}
