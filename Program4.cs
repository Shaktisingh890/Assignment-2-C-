using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Logger.setNameAndPassword("Ritik", 1234);
            Logger.Login("Ritik", 1234);

        }
    }

    public static class Logger
    {
        static string name;
        static int password;
        public static void setNameAndPassword(string username, int userpassword)
        {
            name = username;
            password = userpassword;
        }
        public static void Login(string username, int userpassword)
        {
            if (username == name && userpassword == password)
            {
                Console.WriteLine("Login SuccessFull");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Login Failed");
                Console.ReadKey();
            }
        }
    }
}
