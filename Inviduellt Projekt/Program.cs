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
                                                                                                                                   
            var Users = new List<string> {"Daniel", "Martin", "Christian", "Neo", "Jennie" };//https://channel9.msdn.com/Series/CSharp-101/CSharp-Sort-Search-and-Index-Lists                
            int[] Passwords = new int[] { 1234, 2345, 3456, 4567, 5678 };

            string[] Daniel = new string[3] { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceDaniel = new double[] { 1235.54, 1531, 1562 };

            string[] Martin = new string[] { "Lönekonto","Sparkonto", "Buffert" };
            double[] BalanceMartin = new double[] { 486, 12, 145861, 15610, 14 };

            string[] Christian = new string[] {"Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceChristian = new double[] { 516.32, 1561, 1515.61 };

            string[] Neo = new string[]  { "Lönekonto", "Sparkonto", "Buffert" };
            double[] BalanceNeo = { 5846.23, 186146, 15136 };

            string[] Jennie = new string[]  { "Lönekonto", "Sparkonto", "Buffert" } ;
            double[] BalanceJennie = { 1353.15, 15864, 1561, 23 }; 

            while (MinBool)
            {
                Console.Write("Var god ange ditt användarnamn: ");
                string User = Console.ReadLine();
                var index = Users.IndexOf(User);
                Console.WriteLine("Hej!" + Users[index]);
                Console.Write("Var god ange din pinkod: ");
                int.TryParse(Console.ReadLine(), out int GivenPassword);

                foreach (var item in Users)
                {
                    if (User == item)
                    {
                        for (int i = 0; i < 2; i++)
                        {
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
                                                    Console.WriteLine(": "+BalanceDaniel[j]);
                                                } 
                                              
                                            }
                                            if (User == "Martin")
                                            {
                                                for (int j = 0; j < Martin.Length; j++)
                                                {
                                                    Console.Write(Martin[j]);
                                                    Console.WriteLine(": " + BalanceMartin[j]);
                                                }
                                            }
                                            if (User == "Christian")
                                            {
                                                for (int j = 0; j < Christian.Length; j++)
                                                {
                                                    Console.Write(Christian[j]);
                                                    Console.WriteLine(": " +BalanceChristian [j]);
                                                }
                                            }
                                            if (User == "Neo")
                                            {
                                                for (int j = 0; j < Neo.Length; j++)
                                                {
                                                    Console.Write(Neo[j]);
                                                    Console.WriteLine(" " + BalanceNeo[j]);
                                                }
                                            }
                                            if (User == "Jennie")
                                            {
                                                for (int j = 0; j < Jennie.Length; j++)
                                                {
                                                    Console.Write(Jennie[j]);
                                                    Console.WriteLine(" " + BalanceJennie[j]);
                                                }
                                            }

                                            break;
                                        case 2:
                                            Console.WriteLine("Överföring mellan konton");
                                            Console.WriteLine("Vilket konto vill du ta pengar från?");
                                            string Withdraw = Console.ReadLine();
                                            Console.WriteLine("Hur mycket vill du flytta?");
                                            int amount =Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Vilket konto vill du flytta till?");

                                            Console.WriteLine("Här är de nya saldona");
                                           
                                            break;
                                        case 3:
                                            Console.WriteLine("Ta ut pengar");
                                            break;
                                        case 4:
                                            Console.WriteLine("Logga ut");
                                            MenyBool = false;
                                            User = "";

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
                            Console.Write("Var god ange din pinkod: ");
                            int.TryParse(Console.ReadLine(), out GivenPassword);
                            }
                        }
                    }
                }
            }
        }
    }
}
