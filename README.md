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

![degiskensonuc](https://user-images.githubusercontent.com/86554799/147878199-bf1d083d-684a-41ff-b09b-cc1d1d16658b.jpg)

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
           //İmplicit Conversion (Bilinçsiz Dönüşüm): Düşük kapasiteli bir değişkeni kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemi.sistem kendisi otomotik              dönüştürür bizim parse convert diye mmetod yazmamıza gerek kalmaz.
           Console.WriteLine("*******İmplicit Conversion*******");
           byte a = 5;
           sbyte b = 30;
           short c = 10;
           
           int d = a+b+c;
           Console.WriteLine("d : "+d);
           
           //Explicit Conversion (Bilinçli Dönüşüm):c# ın kendi kendine yapamadığı tür dönüşümleridir. Bir şekilde convert ve parse ı ve de ToString() i kulanarak buradaki        dönüşümü derleyiciye belirtmek gerekiyor.
           Console.WriteLine("*******Explicit Conversion*******");
           int x = 4;
           byte y = (byte)x; //byte y = (byte)x -->sağdaki değişkeni parantez içerisindeki türe dönüştürür.
           Console.WriteLine("y : "+y);
           
            //******ToString() Metodu ****** 
           Console.WriteLine("*******ToString() Metodu*******");
           int xx = 6;
           string yy = xx.ToString();
           Console.WriteLine("yy : "+yy);
           
            //Parse --->Not:Bir değişkeni aynı blokta aynı isimle tanımlayamayız fakat farklı blokta tanımlayabiliriz.Değişken adları tükendiği düşünüldüğü için ayrı metod     tanımlandı.
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

![tipDonusumleri](https://user-images.githubusercontent.com/86554799/147878260-fef9d023-b3e4-4b08-9dac-9e9b555da05e.jpg)

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

![forloopsonuc2](https://user-images.githubusercontent.com/86554799/147877131-20809f70-1dd2-46a7-af12-181fcb0f761e.jpg)

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

![forloopsonuc4](https://user-images.githubusercontent.com/86554799/147877093-061440d3-bc1c-44bf-835e-ae54d7df20bd.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Dokuzuncu uygulamamı da **_Uygulamalar/donguler_while_foreach/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de döngü yapılarından while ve foreach döngüsünün nasıl kullanıldığını  inceleyip  bununla ilgili uygulamalar geliştirdim.

While Tanım:Belli bir kod bloğunun belli şartlar altında,şartlara bağlı kalarak birden fazla defa çalışmasını istiyorsak döngülerden yararlanırız.Bunlardan biri de while loop(döngü) kullanılır.While döngüsünün kullanımı: 

            while(koşul)
            {
               çalışacak ifadeler
            }

-**İlk Örnek:** 1 den  Başlayarak console dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console a yazdıran program.

**Program Kodları**(Kısa olduğu için direk kodları olduğu gibi burada gösterdim)

```
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

```

**Program Sonucu**

![while1](https://user-images.githubusercontent.com/86554799/147877507-ac63d6d5-c806-40ba-bc78-e91847d52afd.jpg)

-**İkinci Örnek:** "a" dan "z" ye kadar olan tüm harfleri console a  yazdıran program.

**Program Kodları **

```
            char character = 'a';
            while (character < 'z')
            {
                 Console.Write(character);
                 character++;
            }
```

**Program Sonucu**

![while2](https://user-images.githubusercontent.com/86554799/147877811-e31b8966-1c81-4267-85c1-9b7a198aeac0.jpg)

-**Üçüncü Örnek:** Foreach ile araba markalarını ekrana yazdıran program.(Foreach dizilerde kullanılır.Dizinin içindeki elemanlar arasında döner)

```
            Console.WriteLine("*****Foreach*****");
            string[]arabalar = {"BMV", "Ford", "Toyota", "Nissan"};  //dizi tanımlaması:veri tipi[]diziadi={değerler}
            foreach (var araba in arabalar) //var ile veritipi belirlemeye gerek kalmadan her veri tipindeki elemanları kontrol edebilir foreach.var obje türünden türemiştir.
            {
                Console.WriteLine(araba);
            }
```

**Program Sonucu**

![foreach](https://user-images.githubusercontent.com/86554799/147878063-6cb4bad9-9804-4ae0-95dc-471cfc66ab49.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Onuncu uygulamamı da **_Uygulamalar/diziler/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede de dizi tanımlama, dizi elemanlara erişme ve dizilerin döngülerde kulllanımını  inceleyip  bununla ilgili uygulamalar geliştirdim.

Dizi Tanım: Aynı tipteki verileri bellekte yan yana saklamak istediğimizde dizilerden faydalanırız.Değişkenler kullanılarak karmaşık şekilde çözülebilecek problemler diziler yardımıyla çok daha kolay bir şekilde çözülebilir.Diziler 0.indisten başlar.Yani 5 elemanlı bir dizi oluşturuyorsak o dizinin son elemanına ulaşmak için 4.indisten ulaşabiliriz.Dizi tanımlaması:

           veri_tipi[] dizi_adi = new veri_tipi[boyut] 
           dizi_adi = {elemanlar}
           
-**İlk Örnek:** Dizileri tanımlama ve dizinin elemanlarına erişim ile ilgili örnekler:

**Program Kodları**

```
            //Dizi Tanımlaması:
            string[] renkler = new string[5];  //Adı renkler olan 5 elemanlı string tipinde bir dizi tanımlanmış oldu.Burada dizinin boyutu belli elemanı belli değildir.
            
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};  //Adı hayvanlar olan 4 elemanlı string tipinde bir dizi.Dizinin elemanları da bellidir,boyutu da.

            int[] dizi;  //Burada boyut da elemanlar da belli değildir.
            dizi = new int[4];  //Daha sonra da kaç elemanlı olacağını burada olduğu gibi belirtebiliriz.

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";  //renkler dizisinin 0.indisindeki yani 1.elemanına "Mavi" elemanını atamış olduk.
            dizi[3] = 10;         //dizi adlı dizinin 3.indisindeki yani 4.elemanına 10 değerini atamış olduk.
            
            Console.WriteLine(hayvanlar[1]);  //hayvanlar dizisinin 1.indisindeki yani 2.elemanına erişmiş olduk ve ekrana yazdırdık.
            Console.WriteLine(dizi[3]);       //dizi adlı dizinin 4.elemanına erişmiş olduk ve ekrana yazdırdık.
            Console.WriteLine(renkler[0]);    //renkler dizisinin 0.indisindeki yani 1.elemanına erişmiş olduk ve ekrana yazdırdık.

```

**Program Sonucu**

![diziler1 sonuc](https://user-images.githubusercontent.com/86554799/148109471-6fe0f74d-db6c-4cc0-86ea-6a7d1093c2ea.jpg)

-**İkinci Örnek:** Klavyeden girilen n tane sayının ortalamasını hesaplayan program.

**Program Kodları**

```
            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program.
            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];   //dizi kullanıcının girdiği sayı kadar elemanlı olacak şekilde tanımlandı.

            //dizinin elemanlarını da kullancı girsin istiyoruz.Bunu da for döngüsü yardımıyla oluşturuyoruz.
            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Lütfen {0}. sayısını giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }

            //dizide bulunan sayıları toplayıp ortalamasını almak için de foreach döngüsünden faydalanıyoruz.
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;
            Console.WriteLine("Ortalaması: " + toplam/diziUzunluğu);
            
```

**Program Sonucu**

![diziler2 sonuc](https://user-images.githubusercontent.com/86554799/148109838-33eabf7e-30b2-438f-9372-53f3a456319c.jpg)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Onbirinci uygulamamı da **_Uygulamalar/diziler_ArraySinifiMetodlari/Program.cs_** klasörünün içerisinde oluşturdum. Bu projede Array Sınıfından olan Sort, Clear, Reverse, IndexOf, ReSize metodlarını inceleyip bunlarla ilgili uygulamalar geliştirdim.

-**İlk Örnek-Sort:** Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.

**Örnek Kodları**

```
             //Diziler System.Array sınıfından türerler. Array sınıfı da dizilerle yapılan işlemleri kolaylaştırmak için bir takım static hazır metotlar sunar.Sık kullanılan Array metotları:

            //Sort:Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.
            
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
            Console.WriteLine("******Sırasız Dizi******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Sıralı Dizi******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

```

**Örnek Sonucu**

![Arraysortsonuc](https://user-images.githubusercontent.com/86554799/148115477-97f2b6f9-2859-4908-9f30-2bc4a32f7de5.jpg)

-**İkinci Örnek-Clear:** Dizi içerisinde verdiğimiz indexten başlayarak verdiğimiz eleman sayısı kadar değeri 0 lar.yani varsayılan değerini döndürür. int türünde varsayılan değer 0 dır.

**Örnek Kodlar**

```

            Console.WriteLine("******Array Clear******");
            Array.Clear(sayiDizisi,2,2);  //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

```

**Örnek Sonucu**

![Arrayclearsonuc](https://user-images.githubusercontent.com/86554799/148115745-6e689aaa-f266-4856-b483-270065a0385c.jpg)

-**Üçüncü Örnek-Reverse:** Dizi elemanlarını tersine sıralar.Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

**Örnek Kodlar**

```
            Console.WriteLine("******Array Reverse******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

```

**Örnek Sonucu**

![Arrayreversesonuc](https://user-images.githubusercontent.com/86554799/148117374-a5e9e0da-78dd-4ead-99e6-6465a9b26b48.jpg)

-**Dördüncü Örnek-IndexOf:** Verdiğiniz dizi üzerinde verdiğiniz elemanın eğer içerisinde varsa index numarasını döner.

**Örnek Kodlar**

```
            //IndexOf:Verdiğiniz dizi üzerinde verdiğiniz elemanın eğer içerisinde varsa index numarasını döner.
            Console.WriteLine("******Array IndexOf******");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
```

**Örnek Sonucu**

![Arrayindexofsonuc](https://user-images.githubusercontent.com/86554799/148116463-0b725e29-cd64-4593-85b9-b2d366642348.jpg)

-**Beşinci Örnek-ReSize:** Yeniden boyutlandırma yapar.

**Örnek Kodlar:**

```
            Console.WriteLine("******Arrayy Resize******");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

```

**Örnek Sonucu**

![arrayresizesonuc](https://user-images.githubusercontent.com/86554799/148116683-2e9e0d66-69d0-4464-b881-4bfe12c8e7ed.jpg)

       



           














