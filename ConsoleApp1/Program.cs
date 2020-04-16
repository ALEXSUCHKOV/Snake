using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Class1 class1 = new Class1();
                    class1.Setup(class1.proigrish);
            while (!class1.proigrish)
            {
                class1.karta_and_pers();
                class1.Input_Logic();
                class1.dvigenie();
                class1.itog();
                Thread.Sleep(150);
            }
            Console.ReadKey();
        }
    }
}