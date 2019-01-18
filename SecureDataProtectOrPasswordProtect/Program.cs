using System;
using System.Configuration;

namespace SecureDataProtectOrPasswordProtect
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = "123456";
            Console.WriteLine("Real Password-" + password);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            SecureDataProtected aDataProtected = new SecureDataProtected();
            Console.WriteLine("Protected Data-" + aDataProtected.Protect(password));
            Console.BackgroundColor = ConsoleColor.Cyan;

            string original = aDataProtected.Unprotect(ConfigurationManager.AppSettings["password"]);
            Console.WriteLine("Unprotected Data-" + original);

            Console.ReadLine();
        }
    }
}