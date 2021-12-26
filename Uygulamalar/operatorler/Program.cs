using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Atama ve İşlemli Atama Operatörleri**********");
            //Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            
            y = y+2;
            Console.WriteLine("y = y+2 : "+y);
            y += 2;  //işlemli atama olur.
            Console.WriteLine("y += 2 : "+y);
            y /= 1; 
            Console.WriteLine("y /= 1 : "+y);
            x *= 2;
            Console.WriteLine("x *= 2 : "+x);

            Console.WriteLine("***********Mantıksal Operatörler**********");
            //Mantıksal Operatörler
            // && || !(Ve,Veya,Değil)
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Fine");  //koşulun biri true diğeri false.ve de her iki koşul sağlanması gerekir.Program burayı atlar.
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Perfect");

            Console.WriteLine("***********İlişkisel Operatörler**********");
            //İlişkisel Operatörler
            // < > >= <= == !=
            int a =3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine("a<b : "+sonuc);
            
            sonuc = a>b;
            Console.WriteLine("a>b : "+sonuc);
            sonuc = a>=b;
            Console.WriteLine("a>=b : "+sonuc);
            sonuc = a<=b;
            Console.WriteLine("a<=b : "+sonuc);
            sonuc = a==b;
            Console.WriteLine("a==b : "+sonuc);
            sonuc = a!=b;
            Console.WriteLine("a!=b : "+sonuc);

            Console.WriteLine("***********Aritmetik Operatörler**********");
            //Aritmetik Operatörler
            // / * + - %-mod alma
            int sayi1 = 10;
            int sayi2 = 5;
            int sonucAo = sayi1/sayi2;
            Console.WriteLine("sayi1/sayi2 : "+sonucAo);
            
            sonucAo = sayi1*sayi2;
            Console.WriteLine("sayi1*sayi2 : "+sonucAo);
            sonucAo = sayi1+sayi2;
            Console.WriteLine("sayi1+sayi2 : "+sonucAo);
            sonucAo = sayi1 ++;
            Console.WriteLine("sayi1++ : "+sayi1);
            sonucAo = sayi1-sayi2;
            Console.WriteLine("sayi1-sayi2 : "+sonucAo);

            int sonucAo2 = 20%3;
            Console.WriteLine("Modu : "+sonucAo2);
        }
    }
}
