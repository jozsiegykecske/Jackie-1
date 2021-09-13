﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
  class Program
  {
    static List<Race> lista = new List<Race>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      Console.ReadKey();
    }

    private static void HatodikFeladat()
    {   
    }

    private static void OtodikFeladat()
    {
      // 2 változó az évtizedeknek
      // Végigmegyünk az adatokon
      //    megnézzük hogy melyik évtized és hozzáadjuk a megfelelő évtizedhez
      int hatvan = 0;
      int hetven = 0;
      for (int i = 0; i < lista.Count; i++)
      {
        if (lista[i].Year<1970)
        {
          hatvan += lista[i].Wins;
        }
        else
        {
          hetven += lista[i].Wins;
        }
      }
      Console.WriteLine($"60-s évek: {hatvan} megnyert verseny");
      Console.WriteLine($"70-s évek: {hetven} megnyert verseny");
    }

    private static void NegyedikFeladat()
    {
      Console.Write("4.feladat: ");
      int legnagyobb = 0;
      int ev=0;
      for (int i = 0; i < lista.Count; i++)
      {
        if (lista[i].Races>legnagyobb)
        {
          legnagyobb = lista[i].Races;
          ev = lista[i].Year;
        }
      }
      Console.WriteLine($"{ev}");
    }

    private static void HarmadikFeladat()
    {
      Console.Write("3.feladat: ");
      Console.WriteLine("{0}",lista.Count);
    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. Feladat: Adatok beolvasása:");
      StreamReader be = new StreamReader("jackie.txt");

      be.ReadLine();

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split('\t');
        lista.Add(new Race(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4]), int.Parse(a[5]))); 
        //Console.WriteLine(be.ReadLine()); [Beolvasás ellenőrzése]
      }
      be.Close();
    }
  }
}
