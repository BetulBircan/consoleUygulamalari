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
                case 5:
                    Console.WriteLine("Mayıs Ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran Ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos Ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül Ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım Ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık Ayındasınız.");
                    break;
                
                default:  // hiçbir case e uymadığı takdirde yapılacak işlemi ifade eder.break  ifadesi ile de çıkış yapılabilir.default kısmı olmak zorundadır.
                    break;
            }
        }
    }
}
