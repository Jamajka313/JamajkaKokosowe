using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku Tablice");
        }
        public int[] Stworz_Tablice()
        {
            Console.WriteLine("ile elementow ma miec tablica?");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj kolejny element tablicy: ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return ints;
        }


        public void Wyswietl_Tablice(int[] tab)
        {
            Console.WriteLine("elementy tablicy: ");
            foreach (int i in tab)
            {
                Console.WriteLine(i + ", ");
            }
            Console.WriteLine();
        }
        public void SortujBabelkowo(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length - i; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
        public bool Przeszukiwanie_Tablicy(int k, int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == k)
                {
                    Console.WriteLine("Element jest w tablicy");
                    return true;
                }
            }
            Console.WriteLine("Elementu nie było w tablicy");
            return false;
        }
    }
}
