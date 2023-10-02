using System;
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
            Console.Clear();
            Console.WriteLine("Addition: " + addition);
            int subtraktion = y - R;
            Console.WriteLine("Subtraktion: " + subtraktion);
            int multiplikation = y * R;
            Console.WriteLine("Multiplikation: " + multiplikation);
            int division = y / R;
            Console.WriteLine("Division: " + division);//
        }
    }
}