using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 3, 5, 7, 2, 9 };
            int toplam = 0;

            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
