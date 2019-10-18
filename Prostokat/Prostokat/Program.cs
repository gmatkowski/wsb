using System;

namespace Prostokat
{
    class Program
    {
        static void Main(string[] args)
        {
            double side_a;
            double side_b;

            Console.WriteLine("Podaj bok A (cm):");
            string user_input_side_a = Console.ReadLine();
            if (double.TryParse(user_input_side_a, out side_a) == false)
            {
                Console.WriteLine("Błędne dane podane z klawiatury");
                return;
            }

            Console.WriteLine("Podaj bok B (cm):");
            string user_input_side_b = Console.ReadLine();
            if (double.TryParse(user_input_side_b, out side_b) == false)
            {
                Console.WriteLine("Błędne dane podane z klawiatury");
                return;
            }

            double field = side_a * side_b;

            Console.WriteLine("Pole prostokąta wynosi: {0}cm/kw", field);
            Console.ReadKey();
        }
    }
}
