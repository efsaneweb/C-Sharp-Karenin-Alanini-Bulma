using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sukruerdem
{
    class kareal_efsaneweb
    {
        static void Main(string[] args)
        {
            int a;
            double alan;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****      Şükrü Erdem AYDIN - Karenin Alanını Hesapla     *****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****          Lütfen Adam Akıllı Bir Sayı Giriniz         *****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ResetColor();
            Console.Write("1 Kenarı Giriniz :");
            a = Convert.ToInt32(Console.ReadLine());
            alan = a * a;
            Console.Write("Kare ALAN : {0}\n", alan);
            Console.ReadKey();
        }
    }
}
