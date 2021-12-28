using System;

namespace if_else_if_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
             //İf-else yapısı
            //şimdiki saati alıp gündüz mü gece mi kontrol eden programı yazma
            int time = DateTime.Now.Hour;  //saati alma

            if(time >=6 && time < 11)
                Console.WriteLine("Günaydın!");
            else if(time<=18)  //Koşul sağlanırsa çalışacağı blok.Tek satır olduğu için {} blokları yazmamıza gerek yok.
                Console.WriteLine("İyi Günler!");
            else  //koşul sağlanmadığı zaman çalışacağı bloktur.
                Console.WriteLine("İyi Geceler!");
        }
    }
}
