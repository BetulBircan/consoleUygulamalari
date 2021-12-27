# Console uygulamaları
C# ta Uygulamalar adlı klasör oluşturuldu.Bundan sonra c# console projeleri bu dosyaya eklenecektir.
-İlk uygulama consoleUygulamaları adlı bir dosya oluşturup ilk uygulamamı yaptım.

** İlk Uygulamam: **

![sonuc](https://user-images.githubusercontent.com/86554799/147359844-3b2c0c32-5e64-4fe9-850e-d0e3722d5de4.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--İkinci uygulamamı da Uygulamalar/degiskenler klasörünün içerisinde oluşturdum. Bu projede de değişken türlerinin nasıl tanımlandığına bakıp tür dönüşümleriyle ilgili uygulama geliştirdim.
Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne bu dosyadan ulaşabilirsiniz. 

** İkinci Uygulamamın kodlarının bir kısmı: **

```
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
```

```
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
```

** Program Sonucu: **

![degiskensonuc](https://user-images.githubusercontent.com/86554799/147374383-6711a8a7-9040-4ae4-97c9-ba7fc88a2fc7.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Üçüncü uygulamamı da Uygulamalar/operatörler klasörünün içerisinde oluşturdum. Bu projede de aritmetik,mantıksal ilişkisel,atama operatörlerin nasıl kullanıldığına bakıp  bunlarla ilgili uygulamalar geliştirdim.
Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne bu dosyadan ulaşabilirsiniz. 

** Üçüncü Uygulamamın kodlarının bir kısmı: **

```
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
```

** Program Sonucu: **

![operatörler](https://user-images.githubusercontent.com/86554799/147396304-9ff94b6d-f292-4ab5-b34b-4ef2614c8060.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Dördüncü uygulamamı da Uygulamalar/tipDonusumleri klasörünün içerisinde oluşturdum. Bu projede de veri tipi dönüşümlerinden implicit convertion(biliçli dönüşüm) ve explicit convertion(bilinçsiz dönüşüm)ın  nasıl kullanıldığına bakıp  bunlarla ilgili uygulamalar geliştirdim.
Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne bu dosyadan ulaşabilirsiniz. 

** Dördüncü Uygulamamın kodlarının bir kısmı: **

```

//Tip Dönüşümleri
           //İmplicit Conversion (Bilinçsiz Dönüşüm): Düşük kapasiteli bir değişkeni kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemi.sistem kendisi otomotik   dönüştürür bizim parse convert diye mmetod yazmamıza gerek kalmaz.
           Console.WriteLine("*******İmplicit Conversion*******");
           byte a = 5;
           sbyte b = 30;
           short c = 10;
           
           int d = a+b+c;
           Console.WriteLine("d : "+d);
           
           //Explicit Conversion (Bilinçli Dönüşüm):c# ın kendi kendine yapamadığı tür dönüşümleridir. Bir şekilde convert ve parse ı ve de ToString() i kulanarak buradaki dönüşümü derleyiciye belirtmek gerekiyor.
           Console.WriteLine("*******Explicit Conversion*******");
           int x = 4;
           byte y = (byte)x; //byte y = (byte)x -->sağdaki değişkeni parantez içerisindeki türe dönüştürür.
           Console.WriteLine("y : "+y);
           
            //******ToString() Metodu ****** 
           Console.WriteLine("*******ToString() Metodu*******");
           int xx = 6;
           string yy = xx.ToString();
           Console.WriteLine("yy : "+yy);
           
            //Parse --->Not:Bir değişkeni aynı blokta aynı isimle tanımlayamayız fakat farklı blokta tanımlayabiliriz.Değişken adları tükendiği düşünüldüğü için ayrı metod tanımlandı.
            Console.WriteLine("*******Parse*******"); 
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = int.Parse(metin1);
            Console.WriteLine("rakam1 : "+rakam1);
            double1 = double.Parse(metin2);
            Console.WriteLine("double1 : "+double1);

        } 

```
** Program Sonucu **

![tipDonusumleri](https://user-images.githubusercontent.com/86554799/147423121-4141ac26-c179-41ab-8f55-7760fe46b78f.jpg)





