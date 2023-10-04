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
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string s = Console.ReadLine();
            int o = Convert.ToInt32(s);
            Console.Clear();
            switch (o)
            {
                case 1:
                    Console.WriteLine("Svar: " + addition);
                    break;
                case 2:
                    Console.WriteLine("Svar: " + subtraktion);
                    break;
                case 3:
                    Console.WriteLine("Svar: " + multiplikation);
                    break;
                case 4:
                    Console.WriteLine("Svar: " + division);
                    break;
                default:
                    Console.WriteLine("Du valde ingen av alternativen ovanför");
                    break;
            }
        }
    }
}