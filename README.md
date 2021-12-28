# Console uygulamaları
C# ta Uygulamalar adlı klasör oluşturuldu.Bundan sonra c# console projeleri bu dosyaya eklenecektir.

-İlk uygulama consoleUygulamaları adlı bir dosya oluşturup ilk uygulamamı yaptım.

**İlk Uygulamam:**

![sonuc](https://user-images.githubusercontent.com/86554799/147359844-3b2c0c32-5e64-4fe9-850e-d0e3722d5de4.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--İkinci uygulamamı da **_Uygulamalar/degiskenler/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de değişken türlerinin nasıl tanımlandığına bakıp tür dönüşümleriyle ilgili uygulama geliştirdim.

Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/degiskenler/Program.cs_** dosyasından ulaşabilirsiniz. 

**İkinci Uygulamamın kodlarının bir kısmı:**

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

**Program Sonucu:**

![degiskensonuc](https://user-images.githubusercontent.com/86554799/147374383-6711a8a7-9040-4ae4-97c9-ba7fc88a2fc7.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Üçüncü uygulamamı da **_Uygulamalar/operatörler/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de aritmetik,mantıksal ilişkisel,atama operatörlerin nasıl kullanıldığına bakıp  bunlarla ilgili uygulamalar geliştirdim.

Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/operatörler/Program.cs_** dosyasından ulaşabilirsiniz. 

**Üçüncü Uygulamamın kodlarının bir kısmı:**

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

**Program Sonucu:**

![operatörler](https://user-images.githubusercontent.com/86554799/147396304-9ff94b6d-f292-4ab5-b34b-4ef2614c8060.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Dördüncü uygulamamı da **_Uygulamalar/tipDonusumleri/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de veri tipi dönüşümlerinden implicit convertion(biliçli dönüşüm) ve explicit convertion(bilinçsiz dönüşüm)ın  nasıl kullanıldığına bakıp  bunlarla ilgili uygulamalar geliştirdim.

Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/tipDonusumleri/Program.cs_** dosyasından ulaşabilirsiniz. 

**Dördüncü Uygulamamın kodlarının bir kısmı:**

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
**Program Sonucu**

![tipDonusumleri](https://user-images.githubusercontent.com/86554799/147423121-4141ac26-c179-41ab-8f55-7760fe46b78f.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Beşinci uygulamamı da **_Uygulamalar/hataYonetimi/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de hata yönetiminden CompireTime ve Runtime hataların  nasıl oluştuğuna ve yönetildiğini inceleyip  bunlarla ilgili uygulamalar geliştirdim.İlk başta hata yönetimi nedir ne değidir bunu belirtmek isterim:

**Hata Yönetimi:**

Hatalar oluşma zamanına göre ikiye ayrılırlar.Compire time ve run time olarak düşünebiliriz.

**Compire Time Hatalar:** Daha biz kodu yazarken derleyicinin bize gösterdiği hatalardır.Mesela değişken tanımlarken değişken tanımlama
kurallarına aykırı bir şekilde tanımlamaya çalışırken daha kodu yazarken derlwyici hata verir.

**Run Time Hatalar:** Programı çalıştırdığımız zamanda ortaya çıkan hatalardır. Run time daki hataları mümkün olduğunca handle etmek
yani yakalıyor olmak  gerekiyor ki programı beklenmedik bir anda kırmasın başka bir probleme yol açmasın...

Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/hataYonetimi/Program.cs_** dosyasından ulaşabilirsiniz. 

**Beşinci Uygulamamın kodlarının bir kısmı:**

```
             try //try içerisine hataya neden olabilecek kodlar yazılır.
             {
                 Console.Write("Bir sayi giriniz: ");
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
             }
             catch(Exception ex)  //hatayı yakaladığı yer.Hata ile karşılaşıldığında ne yapılacağı buraya yazılır.
             {
                 Console.WriteLine("Hata: "+ex.Message.ToString()); 
             }
             finally   //Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız.Burayı yazmak zorunlu değil.
             {
                 Console.WriteLine("işlem Tamamlandı.");
             }
             
             //Kendimiz özel hata mesajı vermek isteyebiliriz.Örneğin;boş değer girdiniz gibi.
            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girilemez!");
                Console.WriteLine(ex);
            }
```
**Program Sonucu**


![hatayonetimi1](https://user-images.githubusercontent.com/86554799/147514023-d0af584d-be18-4c84-9cba-07a9a71a9ce5.jpg)
![hatayonetimi2](https://user-images.githubusercontent.com/86554799/147514025-9ca55d46-5819-49b6-a92b-2959865c96bd.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--Altıncı uygulamamı da **_Uygulamalar/if_else_if_ternary/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de karar yapılarından if, else-if ve ternary yapılarının  nasıl kullanıldığını  inceleyip  bunlarla ilgili uygulamalar geliştirdim.Bu uygulama sistem saatine göre kullanıcıyı karşılayan uygulamadır.

Ben buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/if_else_if_ternary_/Program.cs** dosyasından ulaşabilirsiniz.

**Altıncı Uygulamamın kodlarının bir kısmı:**

```
            //İf-else yapısı
            //şimdiki saati alıp gündüz mü gece mi kontrol eden programı yazma
            int time = DateTime.Now.Hour;  //saati alma

            if(time >=6 && time < 11)
                Console.WriteLine("Günaydın!");
            //Daha sonradan İyi Akşamlar kısmının da yazmasını istediğim için yazılan kodlar..
            else if(time >=12 && time <=18)  //Koşul sağlanırsa çalışacağı blok.Tek satır olduğu için {} blokları yazmamıza gerek yok.
                Console.WriteLine("İyi Günler!");
            else if(time > 18 && time < 24)
                Console.WriteLine("İyi Akşamlar!");
                
            //Ternary ile koşul ifadesi yazma.
            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler";
            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; //iç içe if else gibi düşünebiliriz
            Console.WriteLine(sonuc);
            
 ```
 
 **Program Sonucu**
 
 ```
 else if(time > 18 && time < 24)
        Console.WriteLine("İyi Akşamlar!");  
 
 ```   
 
 Kodu eklenmeden önce:
 
 ![ifelsesonuc](https://user-images.githubusercontent.com/86554799/147614889-d7c7a301-1882-49d3-8b1f-660be78e234c.jpg)
 
 Eklendikten sonra:
  
![ifelsesonuc2](https://user-images.githubusercontent.com/86554799/147615008-0f16b23e-759f-4a8b-9c69-2954fe138709.jpg)

