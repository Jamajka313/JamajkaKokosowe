﻿using System;
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
    }
}