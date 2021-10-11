using System;
using System.Collections.Generic;

namespace Inviduellt_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till banken!");
            bool MinBool = true;
            //List with alla users
            var Users = new List<string> { "Daniel", "Martin", "Christian", "Neo", "Jennie" };//https://channel9.msdn.com/Series/CSharp-101/CSharp-Sort-Search-and-Index-Lists                
            string[] Passwords = { "1234", "2345", "3456", "4567", "5678" };

            string[] Daniel = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceDaniel = { 1235.54, 1531, 1562 };

            string[] Martin = { "Lönekonto", "Sparkonto", "Buffert", "Pension" };
            double[] BalanceMartin = { 486.12, 145861, 15610, 14 };

            string[] Christian = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceChristian = { 516.32, 1561, 1515.61 };

            string[] Neo = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceNeo = { 5846.23, 186146, 15136 };

            string[] Jennie = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceJennie = { 1353.15, 15864, 1561, 23 };

            while (MinBool)
            {
                Console.Write("Var god ange ditt användarnamn: ");
                string User = Console.ReadLine();

                var index = Users.IndexOf(User);


                foreach (var item in Users)
                {
                    if (User == item)
                    {
                        Console.WriteLine("Hej!" + Users[index]);

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Var god ange din pinkod: ");
                            string GivenPassword = Console.ReadLine();


                            if (GivenPassword == Passwords[index])
                            {
                                bool MenyBool = true;
                                while (MenyBool)
                                {
                                    Console.WriteLine("Vad vill du göra?");
                                    Console.WriteLine("[1] Se dina konton och saldo");
                                    Console.WriteLine("[2] Överföring mellan konton");
                                    Console.WriteLine("[3] Ta ut pengar");
                                    Console.WriteLine("[4] Logga ut");
                                    int.TryParse(Console.ReadLine(), out int choice);
                              
                                    switch (choice)
                                    {

                                        case 1:
                                            Console.WriteLine("Se dina konton och saldo");
                                       

                                            if (User == "Daniel")
                                            {
                                                for (int j = 0; j < Daniel.Length; j++)
                                                {
                                                    Console.Write(Daniel[j]);
                                                    Console.WriteLine(": " + BalanceDaniel[j] + " kr");
                                                }
                                            }
                                            if (User == "Martin")
                                            {
                                                for (int j = 0; j < Martin.Length; j++)
                                                {
                                                    Console.Write(Martin[j]);
                                                    Console.WriteLine(": " + BalanceMartin[j] + " kr");
                                                }
                                            }
                                            if (User == "Christian")
                                            {
                                                for (int j = 0; j < Christian.Length; j++)
                                                {
                                                    Console.Write(Christian[j]);
                                                    Console.WriteLine(": " + BalanceChristian[j] + " kr");
                                                }
                                            }
                                            if (User == "Neo")
                                            {
                                                for (int j = 0; j < Neo.Length; j++)
                                                {
                                                    Console.Write(Neo[j]);
                                                    Console.WriteLine(" " + BalanceNeo[j] + " kr");
                                                }
                                            }
                                            if (User == "Jennie")
                                            {
                                                for (int j = 0; j < Jennie.Length; j++)
                                                {
                                                    Console.Write(Jennie[j]);
                                                    Console.WriteLine(" " + BalanceJennie[j] + " kr");
                                                }
                                            }

                                            break;
                                        case 2:
                                            Console.WriteLine("Överföring mellan konton");
                                            for (int j = 0; j < Daniel.Length; j++)
                                            {
                                                Console.Write("[" + (j + 1) + "]" + Daniel[j]);
                                                Console.WriteLine(": " + BalanceDaniel[j] + " kr");
                                            }
                                            Console.WriteLine("Vilket konto vill du ta pengar från?");
                                            int.TryParse(Console.ReadLine(), out int accountChoice);

                                            switch (accountChoice)
                                            {

                                                case 1:
                                                    int indexaccount = 0;
                                                    Console.WriteLine(BalanceDaniel[indexaccount]);
                                                    Console.WriteLine("Hur mycket vill du flytta? ");
                                                    int amount1 = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Vilket konto vill du flytta till?");
                                                    int fromAccount = Convert.ToInt32(Console.ReadLine())-1;
                                                    Console.WriteLine("Här är de nya saldona");
                                                    BalanceDaniel[indexaccount] = BalanceDaniel[indexaccount] - amount1;
                                                    BalanceDaniel[fromAccount] = BalanceDaniel[fromAccount] + amount1;
                                                    Console.WriteLine(Daniel[indexaccount]);
                                                    Console.WriteLine(BalanceDaniel[indexaccount]);
                                                    Console.WriteLine(Daniel[fromAccount]);
                                                    Console.WriteLine(BalanceDaniel[fromAccount]);
                                                    break;

                                                case 2:
                                                    int indexaccount1 = 1;
                                                    Console.WriteLine(BalanceDaniel[indexaccount1]);
                                                    Console.WriteLine("Hur mycket vill du flytta? ");
                                                    int amount2 = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Vilket konto vill du flytta till?");
                                                    Console.WriteLine("Här är de nya saldona");
                                                    BalanceDaniel[indexaccount1] = BalanceDaniel[indexaccount1] - amount2;
                                                    Console.WriteLine(BalanceDaniel[indexaccount1]);
                                                    break;


                                                case 3:
                                                    int indexaccount2 = 2;
                                                    Console.WriteLine(BalanceDaniel[indexaccount2]);
                                                    Console.WriteLine("Hur mycket vill du flytta? ");
                                                    int amount3 = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("Vilket konto vill du flytta till?");
                                                    Console.WriteLine("Här är de nya saldona");
                                                    BalanceDaniel[indexaccount2] = BalanceDaniel[indexaccount2] - amount3;
                                                    Console.WriteLine(BalanceDaniel[2]);
                                                    break;

                                                default:
                                                    Console.WriteLine("var god ange ett kontonummrs siffra");
                                                    break;
                                            }

                                            break;
                                        case 3:
                                            Console.WriteLine("Ta ut pengar");

                                            break;
                                        case 4:
                                            Console.WriteLine("Logga ut");
                                            MenyBool = false;
                                            break;
                                        default:
                                            Console.WriteLine("Du har angivit ett ogiltigt val");
                                            break;
                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("Fel pinkod försök igen");
                            }

                        }
                        MinBool = false;
                    }
                }
            }
        }
        static void MoneyTransfer()
        {
            string[] Daniel = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceDaniel = { 1235.54, 1531, 1562 };

            string[] Martin = { "Lönekonto", "Sparkonto", "Buffert", "Pension" };
            double[] BalanceMartin = { 486.12, 145861, 15610, 14 };

            string[] Christian = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceChristian = { 516.32, 1561, 1515.61 };

            string[] Neo = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceNeo = { 5846.23, 186146, 15136 };

            string[] Jennie = { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceJennie = { 1353.15, 15864, 1561, 23 };

            Console.WriteLine("Överföring mellan konton");
            for (int j = 0; j < Daniel.Length; j++)
            {
                Console.Write("[" + (j + 1) + "]" + Daniel[j]);
                Console.WriteLine(": " + BalanceDaniel[j] + " kr");
            }
            Console.WriteLine("Hur mycket vill du flytta? ");
            int amount3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vilket konto vill du flytta till?");

            Console.WriteLine("Här är de nya saldona");
            BalanceDaniel[0] = BalanceDaniel[0] - amount3;
            Console.WriteLine(BalanceDaniel[0]);


        }

        //static void withdrawMoney()
        //{

        //}
        //public static int IndexOf(Array array, object? value);
        //{
        //Console.WriteLine("index");
        //}
    }
}
