using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guess_a_number
{
    class Program
    {
        static void ShowHighscore()
        {
            using (StreamReader read = new StreamReader(@"C:\Users\emil41m5\source\repos\EX20StreamReader\Highscore.txt"))
            {
                Console.WriteLine(read.ReadToEnd());
            }
        }
        static void SaveHighscore(int tal, string forNavn)
        {
            using (StreamWriter write = new StreamWriter(@"C:\Users\emil41m5\source\repos\EX20StreamReader\Highscore.txt", true))
            {
                write.WriteLine(tal + " " + forNavn);
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(10);

            //Skal slettes senere
            Console.WriteLine(a);

            Console.WriteLine("Gæt et tal mellem 0 og 10.");

            int b = int.Parse(Console.ReadLine());
            int count = 1;

            while ( b != a)
            {
                Console.WriteLine("Gæt igen");
                b = int.Parse(Console.ReadLine());
                count++;
            }

            Console.WriteLine("Du har gættet rigtigt og brugt " + count + " gæt!");
            Console.Write("Indtast dit navn: ");

            string navn = Console.ReadLine();

            SaveHighscore(count, navn);
            ShowHighscore();
        }
    }
}
