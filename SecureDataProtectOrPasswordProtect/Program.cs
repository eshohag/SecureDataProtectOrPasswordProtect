using System;
using System.Configuration;

namespace SecureDataProtectOrPasswordProtect
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptoEnginee = "Shohag";
            Console.WriteLine("Original Name- " + cryptoEnginee);
            string encript = CryptoEngine.Encrypt(cryptoEnginee);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Encrypt Text- " + encript);
            Console.BackgroundColor = ConsoleColor.Black;

            string decript = CryptoEngine.Decrypt(encript);
            Console.WriteLine("Decript Text- " + decript);


            Console.WriteLine();


            string password = "123456";
            Console.WriteLine("Original Password-" + password);

            Console.BackgroundColor = ConsoleColor.DarkRed;
            SecureDataProtected aDataProtected = new SecureDataProtected();
            Console.WriteLine("Protected Data-" + aDataProtected.Protect(password));
            Console.BackgroundColor = ConsoleColor.Black;

            string original = aDataProtected.Unprotect(ConfigurationManager.AppSettings["password"]);
            Console.WriteLine("Unprotected Data-" + original);

            Console.ReadLine();
        }
    }
}