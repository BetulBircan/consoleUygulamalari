using System;

namespace diziler_ArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Clear:Dizi içerisinde verdiğimiz indexten başlayarak verdiğimiz eleman sayısı kadar değeri 0 lar.yani varsayılan değerini döndürür. int türünde varsayılan değer 0 dır.
            
            Console.WriteLine("******Array Clear******");
            Array.Clear(sayiDizisi,2,2);  //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse:Dizi elemanlarını tersine sıralar.Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

            Console.WriteLine("******Array Reverse******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf:Verdiğiniz dizi üzerinde verdiğiniz elemanın eğer içerisinde varsa index numarasını döner.
            Console.WriteLine("******Array IndexOf******");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //ReSize:Yeniden boyutlandırma yapar.
            Console.WriteLine("******Arrayy Resize******");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
}
