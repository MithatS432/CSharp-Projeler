using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Örnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime girin: ");
            string kelime = Console.ReadLine().ToLower();
            string ters = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                ters += kelime[i];
            }

            if (kelime == ters)
                Console.WriteLine("Palindromdur.");
            else
                Console.WriteLine("Palindrom değildir.");
        }
    }
}
