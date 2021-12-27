using System;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hata Yönetimi:
            /*Hatalar oluşma zamanına göre ikiye ayrılırlar.Compire time ve run time olarak düşünebiliriz.
            Compire Time Hatalar: Daha biz kodu yazarken derleyicinin bize gösterdiği hatalardır.Mesela değişken tanımlarken değişken tanımlama
            kurallarına aykırı bir şekilde tanımlamaya çalışırken daha kodu yazarken derlwyici hata verir.
            Run Time Hatalar: Programı çalıştırdığımız zamanda ortaya çıkan hatalardır. Run time daki hataları mümkün olduğunca handle etmek
            yani yakalıyor olmak  gerekiyor ki programı beklenmedik bir anda kırmasın başka bir probleme yol açmasın...
            */
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
        }
    }
}
