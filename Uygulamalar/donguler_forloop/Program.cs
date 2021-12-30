﻿using System;

namespace donguler_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            //Belli bir kod bloğunun belli şartlar altında,şartlara bağlı kalarak birden fazla defa çalışmasını istiyorsak for loop(döngü) kullanılır.
            //for(başlangıç noktası;koşul;artım)

            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
            int tekToplam = 0, ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;  //tekToplam = tekToplam + i;  
                else
                    ciftToplam += i; //ciftToplam = tekToplam + i;
            }
            Console.WriteLine("Tek Sayıların Toplamı: "+tekToplam);
            Console.WriteLine("Çift Sayıların Toplamı: "+ciftToplam);
        }
    }
}
