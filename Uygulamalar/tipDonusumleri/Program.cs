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

           //Explicit Conversion (Bilinçli Dönüşüm):c# ın kendi kendine yapamadığı tür dönüşümleridir. Bir şekilde convert ve parse ı ve de ToString() i kulanarak buradaki dönüşümü derleyiciye belirtmek gerekiyor.
           Console.WriteLine("*******Explicit Conversion*******");
           int x = 4;
           byte y = (byte)x; //byte y = (byte)x -->sağdaki değişkeni parantez içerisindeki türe dönüştürür.
           Console.WriteLine("y : "+y);

           int z = 100;
           byte t = (byte)z;
           Console.WriteLine("t : "+t);

           float w = 10.3f;
           byte v = (byte)w;
           Console.WriteLine("v : "+v);
        }
    }
}
