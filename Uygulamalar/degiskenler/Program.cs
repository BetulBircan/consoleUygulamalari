using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5;   //1 byte-0 ile 256
            sbyte c = 5;  //1 byte -128---+127

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte 0 ve pozitif sayılar alır

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 2;    //4 byte  işaretsiz
            long l = 4;     //8 byte  
            ulong ul = 4;   //8 byte işaretsiz

            //Reel Sayılar
            float f = 5;        //4 byte
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            //Mantıksal değer
            char ch = '2';          //2 byte
            string str = "Betül";   //sınırsız

            //Tarih
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "xxx";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 12.5;

            //string ifadeler
            //ilk tanımlandığında içinde değer olmamasını istemiyorsak üç şekilde kullanılır:
            //string str1 = "";     string str = null;
            string str1 = string.Empty;
            str1 = "Betül Bircan";
            string ad = "Betül";
            string soyad = "BİRCAN";
            string tamIsim = ad + " " + soyad;
            
            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bo1 = 10<2;  //false değeri döner

            //Değişken Dönüşümleri
            //int ten stringe dönüştürme
            string s20 = "20";
            int i20 = 20;
            string yenideger = s20 + i20.ToString();
            Console.WriteLine(yenideger);  //Çıktı:2020

            //stringden inte dönüştürme
            //int i21 = i20 + Convert.ToInt32(s20);
            int i21 = i20 + int.Parse(s20);
            Console.WriteLine(i21);  //Çıktı:40

            //DateTime-Stirnge dönüştürme
            string  datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);  //sistem gün ay yıl
            
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);  //sistem gün ay yıl / ile

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);  //sistem saat dakika

        }
    }
}
