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
                var Passwords = new List<string> { "1234", "2345", "3456", "4567", "5678" };
            
                Console.Write("Var god ange ditt användarnamn: ");
                string User = Console.ReadLine();
                var index = Users.IndexOf(User);
              


                //string[] Password = new string[] { "1234","2345", "3456", "4567", "5678" };
                foreach (var item in Users)
                {

                    if (User == item)
                    {

                        Console.WriteLine("Hej!" + User);
                        Console.WriteLine("Var god ange din pinkod: ");
                        string GivenPassword = Console.ReadLine();

                        for (int i = 0; i < 2; i++)
                        {
                            if (GivenPassword == Passwords[index])
                            {
                                MinBool = false;
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
                                            break;
                                        case 2:
                                            Console.WriteLine("Överföring mellan konton");
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
                                }    MinBool = true;
                            }
                            else
                            {
                                Console.WriteLine("Fel pinkod försök igen");
                                Console.Write("Var god ange din pinkod: ");
                                GivenPassword = Console.ReadLine();

                            }
                            
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
