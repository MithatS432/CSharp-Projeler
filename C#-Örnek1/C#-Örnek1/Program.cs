using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Sayı çifttir.");
            else
                Console.WriteLine("Sayı tektir.");
        }
    }
}
