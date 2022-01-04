using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
             //Diziler
            /*Diziler:Aynı tipteki verileri bellekte yan yana saklamak istediğimizde dizilerden faydalanırız.Değişkenler kullanılarak karmaşık şekilde çözülebilecek problemler diziler yardımıyla çok daha kolay bir şekilde çözülebilir.Diziler 0.indisten başlar.Yani 5 elemanlı bir dizi oluşturuyorsak o dizinin son elemanına ulaşmak için 4.indisten ulaşabiliriz.
            */

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

        }
    }
}
