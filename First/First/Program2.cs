using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imię: "); //Your name
            Console.WriteLine("Janusz");
            /*
             * Komentarz
             * w 
             * wielu
             * liniach
            */

            string name = "Anna";
            Console.WriteLine(name);
            // + konkatenacja
            Console.WriteLine("Masz na imię: " + name);
            Console.Write("Masz na imię: ");
            Console.WriteLine(name);

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 18;
            sbyte age1 = 20;

            Console.WriteLine("Imię: {0}, Wiek: {1}", name, age);
            Console.WriteLine("Imię: {0}, Wiek: {1}", name, age1);

            Console.ReadKey();
        }
    }
}
