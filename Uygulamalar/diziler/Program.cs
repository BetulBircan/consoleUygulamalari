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
        }
    }
}
