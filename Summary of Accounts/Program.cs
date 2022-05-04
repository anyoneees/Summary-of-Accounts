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
            Console.WriteLine("************************************************");
            Console.WriteLine("*                                              *");
            Console.Write("*       ");
            Console.Write(Console.Title);
            Console.WriteLine("     *");
            Console.WriteLine("*                                              *");
            Console.WriteLine("************************************************");
            Console.ReadLine();

            string tempName = "Имя:               ";
            Console.Write(tempName);
            ConsoleColor LastNameColor = ConsoleColor.Cyan;
            Console.ForegroundColor = LastNameColor;
            string tempLastName = "Биксби, Алвин Майкл";
            Console.WriteLine(tempLastName);
            ConsoleColor NameColor = ConsoleColor.White;
            Console.ForegroundColor = NameColor;
            string tempAcc = "Тип аккаунта:      ";
            Console.Write(tempAcc);
            ConsoleColor ChekingColor = ConsoleColor.Blue;
            Console.ForegroundColor = ChekingColor;
            string tempCheking = "Проверка";
            Console.WriteLine(tempCheking);
            Console.ForegroundColor = NameColor;
            string tempBalance = "Баланс:            ";
            Console.Write(tempBalance);
            ConsoleColor BalanceColor = ConsoleColor.Red;
            Console.ForegroundColor = BalanceColor;
            string tempSecondBalance = "-33.77";
            Console.WriteLine(tempSecondBalance);
            Console.ReadLine();
            Console.ForegroundColor = NameColor;
            Console.Write(tempName);
            Console.ForegroundColor = LastNameColor;
            string tempSecondLastName = "Карлофф, Борис Винстон";
            Console.WriteLine(tempSecondLastName);
            Console.ForegroundColor = NameColor;
            string tempSecondAcc = "Тип аккаунта:      ";
            Console.Write(tempSecondAcc);
            Console.ForegroundColor = ChekingColor;

            Console.WriteLine(tempCheking);
            Console.ForegroundColor = NameColor;
            string tempWhirdBalance = "Баланс:            ";
            Console.Write(tempWhirdBalance);
            ConsoleColor SecondBalanceColor = ConsoleColor.Green;
            Console.ForegroundColor = SecondBalanceColor;
            string tempForthBalance = "14551.52";
            Console.WriteLine(tempForthBalance);
            Console.ReadLine();
        }
    }
}
