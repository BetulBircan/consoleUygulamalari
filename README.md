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
            //Tam Sayılar
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

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Yedinci uygulamamı da **_Uygulamalar/switch_case/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de karar yapılarından switch-case yapısının nasıl kullanıldığını  inceleyip  bununla ilgili uygulamalar geliştirdim.

Tanım:Switch-Case deyimi if-else deyimleri gibi karar kontrol yapılarıdır. Switch-Case ifadeleri yapabileceğiniz her şeyi if-else blokları ile de yapabiliriz. Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel olarak if-else'e alternatif olarak switch case kullanılır.

-**İlk Örnek:** Kullanıcının bilgisayardaki sistem ayını DateTime.Now.Month; ile int değerini alıp daha sonra da hangi ayda olduğunu ve de hangi mevsimde olduğunustring ile ekrana gösteren program.Ben ilk başta hangi ayda olduğunu gösteren kodu yazdım.Buraya kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/switch_case/Program.cs** dosyasından ulaşabilirsiniz.

**Yedinci Uygulama/1.örnek uygulama kodlarının bir kısmı:**

```
  
            //switch-case yapısı: Birden fazla koşulda aynı ifadenin çalışması gereken durumlarda daha temiz, daha okunabilir bir kod ifadesi sağlar.
            
            /*switch (expression)--->Expression yani kontrol etmek istediğimiz koşulu yazarız.biz ay üzerinden kontrol etmek istiyoruz.
                                O yüzden parantez içine month yazarız.
            case 1 : sağlanacağı koşul yazılır.örneğin; month 1 değerindeyse şunu yap gibi.case in yanına yazılan ifade switch için içerisinde
                     yazılan değişkenin veri tipiyle aynı olmalıdır. month değişkeni integer olduğu için case in yanında ki değer de integer
                     olacaktır.
            break; case 1 de yapılacak iş belirlendikten sonra break ifadesi yazılır ve o durumdan çıkılır.
                 case 1:
                    Console.WriteLine("Ocak Ayındasınız.");
                    break;  BU ŞWKİLDE YAZILIR VE DİĞER AYLAR DA BU ŞEKİLDE KONTROL EDİLİR.HİÇBİRİ UYMAZSA DEFAULT DA ÇIKIŞ YAPILIR.
            */

            //kullanıcının sistemdeki ayına göre hangi ayda olduğunu gösteren program
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız.");
                    break;
```

**Programın Sonucu:**

![switchcasesonucilk](https://user-images.githubusercontent.com/86554799/147709811-55b8265d-43d2-4e21-a037-d315f555131a.jpg)

-Daha sonra da Kullanıcının bilgisayardaki sistem ayını DateTime.Now.Month; ile int değerini alıp daha sonra da hangi mevsimde olduğunu string ile ekrana gösteren programın kodlarını yazdım.Buraya da diğer kodların bir kısmını paylaşacağım. Detaylı kod bölümüne **_Uygulamalar/switch_case/Program.cs** dosyasından ulaşabilirsiniz.

**Yedinci Uygulama/2.örnek uygulama kodlarının bir kısmı:**

```
 /*Eğer birden fazla case de aynı işlemi yapmak istersek birden fazla case ifadesini tek bir kod bloğunu çalıştırabilecek şekilde yazabiliriz.
                Örneğin : case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz.");
                    break; gibi.
            */
            
            //Kullanıcının sistemdeki ayına göre hangi mevsimde olduğunu gösteren program.
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz.");
                    break;
```

**Programın Sonucu**

![switchcasesonuc](https://user-images.githubusercontent.com/86554799/147710191-cb7f5ed1-8625-4427-a15a-35e96fd24ea3.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Sekizinci uygulamamı da **_Uygulamalar/donguler_forloop/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de döngü yapılarından for döngüsünün nasıl kullanıldığını  inceleyip  bununla ilgili uygulamalar geliştirdim.

Tanım:Belli bir kod bloğunun belli şartlar altında,şartlara bağlı kalarak birden fazla defa çalışmasını istiyorsak döngülerden yararlanırız.Bunlardan biri de for loop(döngü) kullanılır.For döngüsünün kullanımı: 

            for(başlangıç noktası;koşul;artım)

-**İlk Örnek:** Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdıran program.

**Program Kodları**(Kısa olduğu için direk kodları olduğu gibi burada gösterdim)

```
Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }
```
**Program Sonucu**

![forloopsonuc1](https://user-images.githubusercontent.com/86554799/147789168-af4a87fe-9970-4455-8977-7a57962f7183.jpg)

-**İkinci Örnek:** 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdıran program.

**Program Kodları**

```
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
```

**Program Sonucu**

![forloopsonuc2](https://user-images.githubusercontent.com/86554799/147789184-03511610-2680-4057-b400-eed20946298b.jpg)

Döngülerde kullanılabilinen iki özel tanım vardır. Bunlar "break" ve "continue" dir.

**Break:** Eğer döngü içerisinde bir case e bağlı olarak döngüden çıkmak istersek yani döngüyü sonlandırmak istersek break ifadesini kullanırız

**Continue:** Eğer bir şarta bağlı olarak  mevcut döngünün o kısmın çalışmasını istemediğimizde o kısmı atlayıp döngüye devam etmek istersek continue ifadesini kullanırız.

-**Üçüncü Örnek:** 1 den 10 a kadar sayılar için break ve continue ile gösterimi:

Break için:

```
 //break ile ilgili örnek:
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
```

**Program Sonucu**

![forloopsonuc3](https://user-images.githubusercontent.com/86554799/147789217-9126d566-c866-4913-8008-ca53a390fb15.jpg)

Continue için:

```
//contine ile ilgili örnek:
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
```

**Program Sonucu**

![forloopsonuc4](https://user-images.githubusercontent.com/86554799/147789234-291d5697-a21f-4ddb-a101-fac17aa80032.jpg)



