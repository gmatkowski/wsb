using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * użytkownik podaje z klawiatury
            * długość boku
           */
            /*
            Console.WriteLine("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a wynosi {0}", a;

            double bok_a = double.Parse(a);
            bok_a *= bok_a;

            Console.WriteLine("Pole kwadratu wynosi {0}", bok_a);
            Console.ReadKey();
            */
            /*
            Console.WriteLine("Podaj podstawa: ");
            string a = Console.ReadLine();

            Console.WriteLine("Podaj wysokość: ");
            string h = Console.ReadLine();


            double bok_a = double.Parse(a);
            double wysokosc_h = double.Parse(h);

            double result = bok_a * wysokosc_h / 2;

            Console.WriteLine("Pole trójkąta wynosi {0}", result);
            */

            string str;
            int liczba;

            Console.WriteLine("Podaj liczbę całkowitą");
            str = Console.ReadLine();

            //liczba = int.Parse(str);
            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Zły format liczby.");

            }
            else
            {
                Console.WriteLine("Liczba wynosi {0}", liczba);
                // Sprawdź czy liczba całkowita podana z klawiatury jest parzysta;
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Liczba {0}, jest parzysta", liczba);
                }
                else {
                    Console.WriteLine("Liczba {0} nie jest przysta", liczba);
                }
            }

            Console.ReadKey();
        }
    }
}
