using System;
namespace inlämningsuppgift3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt namn och efternamn: ");
            string x = Console.ReadLine();
            if (x.Contains("a"))
            {
                Console.WriteLine("Ditt namn kommer först i bokstavs ordning");
            }
            else
            {
                Console.WriteLine("Ditt namn kommer inte först i bokstavsordningen");//
            }
        }
    }
}