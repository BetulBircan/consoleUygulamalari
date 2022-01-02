using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Kullanımı:while(kosul){çalışacak kodlar}
            //Birden Başlayarak console dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console a yadıran program.
            Console.Write("Lütfen Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1; //1 den girilen sayıya kadar dediği için
            int toplam = 0;

            while (sayac <= sayi) //buraya yazdığımız ifade true olduğu sürece kod blokları çalışacaktır.Döngünün kaç kere çalışacağını  bu koşul belirler.
            {
                 toplam += sayac;
                 sayac++; //sayac++ demezsek sonsuz döngü olur.
            }
            Console.WriteLine("0rtalaması:" + toplam/sayi);
            
            
        }
    }
}
