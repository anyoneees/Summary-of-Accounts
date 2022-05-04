using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Summary of Accounts <By Last Name>";
            ConsoleColor BackGroundTable = ConsoleColor.Blue;
            Console.BackgroundColor = BackGroundTable;
            Console.WriteLine("*********************************************");
            Console.WriteLine("*                                           *");

            Console.WriteLine($"{"*",-4} {Console.Title,35} {"   *"}");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*********************************************");
            Console.ReadLine();
            ConsoleColor BackGround = ConsoleColor.Black;
            Console.BackgroundColor = BackGround;
            string name = "Биксби, Алвин Майкл";
            Console.Write($"{"Имя:",-9}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{name,9}");
            ConsoleColor LastNameColor = ConsoleColor.Cyan;
            ConsoleColor NameColor = ConsoleColor.White;
            Console.ForegroundColor = NameColor;
            string tempAcc = "Проверка";
            Console.Write($"{"Тип аккаунта:      ",-9} ");
            ConsoleColor ChekingColor = ConsoleColor.Blue;
            Console.ForegroundColor = ChekingColor;
            Console.WriteLine($"{tempAcc,9}");
            Console.ForegroundColor = NameColor;
            string tempBalance = "-33.77";
            Console.Write($"{"Баланс:            ",-9}");
            ConsoleColor SecondBalanceColor = ConsoleColor.Green;
            ConsoleColor BalanceColor = ConsoleColor.Red;
            Console.ForegroundColor = BalanceColor;
            Console.WriteLine($"{tempBalance,9}");
            Console.ForegroundColor = BalanceColor;
            Console.ReadLine();
            Console.ForegroundColor = NameColor;
            string nameSecond = "Карлофф, Борис Винстон";
            Console.Write($"{"Имя:",-9}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{nameSecond,9}");
            Console.ForegroundColor = LastNameColor;
            Console.ForegroundColor = NameColor;
            Console.Write($"{"Тип аккаунта:      ",-9} ");
            ConsoleColor chekingColor = ConsoleColor.Blue;
            Console.ForegroundColor = chekingColor;
            Console.WriteLine($"{tempAcc,9}");
            Console.ForegroundColor = NameColor;
            string tempWhirdBalance = "14551.52";
            Console.Write($"{"Баланс:            ",-9}");
            Console.ForegroundColor = SecondBalanceColor;
            Console.WriteLine($"{tempWhirdBalance,9}");
            Console.ReadLine();
        }
    }
}
