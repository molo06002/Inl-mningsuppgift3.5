using System;
using System.Threading.Channels;

namespace inlämningsuppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in  tal nmr 1: ");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.WriteLine("Skriv in tal nmr 2: ");
            string r = Console.ReadLine();
            int R = Convert.ToInt32(r);
            int addition = y + R;
            int subtraktion = y - R;
            int multiplikation = y * R;
            int division = y / R;
            Console.WriteLine("Välj en kalkulation: ");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraktion");
            Console.WriteLine("Multiplikation");
            Console.WriteLine("Division");
            string s = Console.ReadLine();
            Console.Clear();
            if (s == "Addition")
            {
                Console.WriteLine("Svar: " + addition);
            }
            if (s == "Subtraktion")
            {
                Console.WriteLine("Svar: " + subtraktion);
            }
            if (s == "Multiplikation")
            {
                Console.WriteLine("Svar: " + multiplikation);
            }
            else
            {
                Console.WriteLine("Svar: " + division);
            }

        }
    }
}