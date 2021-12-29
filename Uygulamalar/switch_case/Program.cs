using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                
                default:
                    break;
            }
        }
    }
}
