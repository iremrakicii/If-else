using System;

namespace If-else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (sayi >= 10)
            {
                if (sayi == 10)
                {
                    Console.WriteLine("Girilen sayı 10'dur.");
                }
                else if (sayi < 10)
                {
                    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
                }

            }
            else
            {
                Console.WriteLine("Girilen sayı sıfırdır.");
            }

            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir");
            }

        }
    }
}

