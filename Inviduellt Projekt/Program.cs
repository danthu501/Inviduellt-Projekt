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
            while (MinBool)
            {

                //string[,] Users = new string[2, 5] {{"Daniel", "Martin", "Christian", "Neo", "Jennie" },
                //                                    {"1234","2345", "3456", "4567", "5678" }};

                
                var Users = new List<string> { "Daniel", "Martin", "Christian", "Neo", "Jennie" };//https://channel9.msdn.com/Series/CSharp-101/CSharp-Sort-Search-and-Index-Lists                
                int[] Passwords = new int[] { 1234, 2345, 3456, 4567, 5678 };
                
                string[] BankAcountNames = new string [] { "Lönekonto", "Lönekonto", "Lönekonto" };
                double[] BankBalance = new double[] { 1235.54, 1531, 1531, 56468 };

                string[] BankAcountNames1 = new string[] { "Lönekonto2", "Lönekonto2", "Lönekonto2" };
                double[] BankBalance1 = new double[] { 1254, 1531, 1531, 56468 };

                Console.Write("Var god ange ditt användarnamn: ");
                string User = Console.ReadLine();
                foreach (var item in Users)
                {
                    if (User == item)
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Det angivna anvädarnamnet finns inte");
                    }
                    
                }
                
                var index = Users.IndexOf(User);
                Console.WriteLine("Hej!" + Users[index]);
                Console.Write("Var god ange din pinkod: ");
                int.TryParse(Console.ReadLine(), out int GivenPassword);

                //string[] Password = new string[] { "1234","2345", "3456", "4567", "5678" };
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
                                            Console.WriteLine(BankAcountNames1[index]);
                                            Console.WriteLine(BankBalance1[index] + "kr");
                                            Console.WriteLine(BankAcountNames[index]);
                                            Console.WriteLine(BankBalance[index]+"kr");
                                            break;
                                        case 2:
                                            Console.WriteLine("Överföring mellan konton");
                                            Console.WriteLine("Vilket konto vill du ta pengar från?");
                                            string Withdraw = Console.ReadLine();
                                                                                                                        
                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                            Console.WriteLine("Här är de nya saldona");
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
                                Console.Write("Var god ange din pinkod: ");
                                int.TryParse(Console.ReadLine(), out GivenPassword);
                            }
                         MinBool = false;
                        }
                        
                        
                    }
                    
                    
                       
                    

                
                
                }
            }
            
            

        }
        static void CheckPassword()
        {

        }
    }
}
