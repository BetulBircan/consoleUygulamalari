using System;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tip Dönüşümleri
           //İmplicit Conversion (Bilinçsiz Dönüşüm): Düşük kapasiteli bir değişkeni kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemi.sistem kendisi otomotik dönüştürür bizim parse convert diye mmetod yazmamıza gerek kalmaz.
           Console.WriteLine("*******İmplicit Conversion*******");
           byte a = 5;
           sbyte b = 30;
           short c = 10;
           
           int d = a+b+c;
           Console.WriteLine("d : "+d);

           long h = d;
           Console.WriteLine("h : "+h);

           float i = h;
           Console.WriteLine("i : "+i);

           string e = "Betül";
           char f = 'k';
           object g = e+f+d;
           Console.WriteLine("g : "+g);  //bütün veri tipleri objectten türemiştir.Bu yüzden object hepsinden üstündedir.
        }
    }
}
