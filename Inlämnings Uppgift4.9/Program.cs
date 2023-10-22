using System;

namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string tecken = "";
            Console.WriteLine("hur stor ska sidlängden på triangeln vara?");
            int bredd = int.Parse(Console.ReadLine());

            for (int i = 0; i < bredd; i++)
            {
                tecken = tecken + "*";
                Console.WriteLine(tecken);
            }
            Console.ReadKey();
        }
    }
}