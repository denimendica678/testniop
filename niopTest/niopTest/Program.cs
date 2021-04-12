using System;
using System.IO;
namespace SpremanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciljnaDatoteka = Path.Combine(@"D:\My Documents\testNiop\MendicaDeniSystemNiOP.csv");

            string ime, prezime, email;
            int gidRod;

            Console.WriteLine("Unesite svoje ime");
            Console.WriteLine("Unesite svoje prezime");
            Console.WriteLine("Unesite svoju godinu rođenja");
            Console.WriteLine("Unesite svoj e-mail");

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(ime + "" + prezime + "" + godRod + "" + email);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}