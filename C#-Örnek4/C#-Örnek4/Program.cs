using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Örnek4
{
    internal class SimpleHashMap
    {
        private const int Boyut = 10;
        private LinkedList<KeyValuePair<string, string>>[] table;

        public SimpleHashMap()
        {
            table = new LinkedList<KeyValuePair<string, string>>[Boyut];
        }

        private int Hash(string key)
        {
            int hash = 0;
            foreach (char c in key)
                hash += c;

            return hash % Boyut;
        }

        public void Ekle(string anahtar, string deger)
        {
            int index = Hash(anahtar);
            if (table[index] == null)
                table[index] = new LinkedList<KeyValuePair<string, string>>();

            foreach (var kv in table[index])
            {
                if (kv.Key == anahtar)
                    return;
            }

            table[index].AddLast(new KeyValuePair<string, string>(anahtar, deger));
        }

        public string Getir(string anahtar)
        {
            int index = Hash(anahtar);
            if (table[index] != null)
            {
                foreach (var kv in table[index])
                {
                    if (kv.Key == anahtar)
                        return kv.Value;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            SimpleHashMap hashmap = new SimpleHashMap();
            hashmap.Ekle("ad", "Mithat");
            hashmap.Ekle("soyad", "Yılmaz");

            Console.WriteLine("Ad: " + hashmap.Getir("ad"));
            Console.WriteLine("Soyad: " + hashmap.Getir("soyad"));
        }
    }
}
