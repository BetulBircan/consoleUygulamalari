using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
