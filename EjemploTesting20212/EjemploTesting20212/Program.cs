using System;

namespace EjemploTesting20212
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia la clase
            var utils = new StringUtilities1();
            string texto = Console.ReadLine();
            bool esPalindrome = utils.Espalindrome(texto);
            if (esPalindrome)
                Console.WriteLine("si es");
            else
                Console.WriteLine("no es");


           // Console.WriteLine("Hello World!");


        }
    }
}
