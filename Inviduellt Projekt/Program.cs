﻿using System;
using System.Collections.Generic;

namespace Inviduellt_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till banken!");

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
            double[] BalanceJennie = { 1353.15, 15864, 1561, 23.25 };

            bool MinBool = true;
            while (MinBool)
            {


                string User = checkLoggin();
                //Console.Write("Var god ange ditt användarnamn: ");
                //string User = Console.ReadLine();

                var index = Users.IndexOf(User);

                foreach (var item in Users)
                {
                    if (User == item)
                    {
                        Console.WriteLine("Hej! " + Users[index]);

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
                                    if (User == "Daniel")
                                    {

                                    }
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
                                            if (User == "Daniel")
                                            {
                                                for (int j = 0; j < Daniel.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Daniel[j]);
                                                    Console.WriteLine(": " + BalanceDaniel[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du flytta pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceDaniel[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du flytta? ");
                                                        double amount1 = Convert.ToDouble(Console.ReadLine());
                                                        try
                                                        {
                                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                                            int fromAccount = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("Här är de nya saldona");
                                                            BalanceDaniel[indexaccount] = BalanceDaniel[indexaccount] - amount1;
                                                            BalanceDaniel[fromAccount] = BalanceDaniel[fromAccount] + amount1;
                                                            Console.WriteLine(Daniel[indexaccount]);
                                                            Console.WriteLine(BalanceDaniel[indexaccount] + " kr");
                                                            Console.WriteLine(Daniel[fromAccount]);
                                                            Console.WriteLine(BalanceDaniel[fromAccount] + " kr");
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Du måste ange en giltig siffra");
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Martin")
                                            {
                                                for (int j = 0; j < Martin.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Martin[j]);
                                                    Console.WriteLine(": " + BalanceMartin[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du flytta pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceMartin[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du flytta? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        try
                                                        {
                                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                                            int fromAccount = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("Här är de nya saldona");
                                                            BalanceMartin[indexaccount] = BalanceMartin[indexaccount] - amount;
                                                            BalanceMartin[fromAccount] = BalanceMartin[fromAccount] + amount;
                                                            Console.WriteLine(Martin[indexaccount]);
                                                            Console.WriteLine(BalanceMartin[indexaccount] + " kr");
                                                            Console.WriteLine(Martin[fromAccount]);
                                                            Console.WriteLine(BalanceMartin[fromAccount] + " kr");
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Du måste ange en giltig siffra");
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Christian")
                                            {
                                                for (int j = 0; j < Christian.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Christian[j]);
                                                    Console.WriteLine(": " + BalanceChristian[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du flytta pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceChristian[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du flytta? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        try
                                                        {
                                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                                            int fromAccount = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("Här är de nya saldona");
                                                            BalanceChristian[indexaccount] = BalanceChristian[indexaccount] - amount;
                                                            BalanceChristian[fromAccount] = BalanceChristian[fromAccount] + amount;
                                                            Console.WriteLine(Christian[indexaccount]);
                                                            Console.WriteLine(BalanceChristian[indexaccount] + " kr");
                                                            Console.WriteLine(Christian[fromAccount]);
                                                            Console.WriteLine(BalanceChristian[fromAccount] + " kr");
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Du måste ange en giltig siffra");
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Neo")
                                            {
                                                for (int j = 0; j < Neo.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Neo[j]);
                                                    Console.WriteLine(": " + BalanceNeo[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du flytta pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceNeo[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du flytta? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        try
                                                        {
                                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                                            int fromAccount = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("Här är de nya saldona");
                                                            BalanceNeo[indexaccount] = BalanceNeo[indexaccount] - amount;
                                                            BalanceNeo[fromAccount] = BalanceNeo[fromAccount] + amount;
                                                            Console.WriteLine(Neo[indexaccount]);
                                                            Console.WriteLine(BalanceNeo[indexaccount] + " kr");
                                                            Console.WriteLine(Neo[fromAccount]);
                                                            Console.WriteLine(BalanceNeo[fromAccount] + " kr");
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Du måste ange en giltig siffra");
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Jennie")
                                            {
                                                for (int j = 0; j < Jennie.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Jennie[j]);
                                                    Console.WriteLine(": " + BalanceJennie[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du flytta pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceJennie[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du flytta? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        try
                                                        {
                                                            Console.WriteLine("Vilket konto vill du flytta till?");
                                                            int fromAccount = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("Här är de nya saldona");
                                                            BalanceJennie[indexaccount] = BalanceJennie[indexaccount] - amount;
                                                            BalanceJennie[fromAccount] = BalanceJennie[fromAccount] + amount;
                                                            Console.WriteLine(Jennie[indexaccount]);
                                                            Console.WriteLine(BalanceJennie[indexaccount] + " kr");
                                                            Console.WriteLine(Jennie[fromAccount]);
                                                            Console.WriteLine(BalanceJennie[fromAccount] + " kr");
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Du måste ange en giltig siffra");
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }



                                            break;
                                        case 3:
                                            Console.WriteLine("Ta ut pengar");
                                            if (User == "Daniel")
                                            {
                                                for (int j = 0; j < Daniel.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Daniel[j]);
                                                    Console.WriteLine(": " + BalanceDaniel[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du ta ut pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceDaniel[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du ta ut? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        Console.Write("Var god ange din pinkod: ");
                                                        string GivenPin = Console.ReadLine();


                                                        if (GivenPin == Passwords[index])
                                                        {
                                                            Console.WriteLine("Här är de nya saldot: ");
                                                            BalanceDaniel[indexaccount] = BalanceDaniel[indexaccount] - amount;
                                                            Console.WriteLine(Daniel[indexaccount]);
                                                            Console.WriteLine(BalanceDaniel[indexaccount] + " kr");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Du angav fel pinkod");
                                                        }
                                                              

                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Martin")
                                            {
                                                for (int j = 0; j < Martin.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Martin[j]);
                                                    Console.WriteLine(": " + BalanceMartin[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du ta ut pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceMartin[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du ta ut? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        Console.WriteLine("Här är de nya saldot");
                                                        BalanceMartin[indexaccount] = BalanceMartin[indexaccount] - amount;
                                                        Console.WriteLine(Martin[indexaccount]);
                                                        Console.WriteLine(BalanceMartin[indexaccount] + " kr");
                                            
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Christian")
                                            {
                                                for (int j = 0; j < Christian.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Christian[j]);
                                                    Console.WriteLine(": " + BalanceChristian[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du ta ut pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceChristian[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du ta ut? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        Console.WriteLine("Här är de nya saldot");
                                                        BalanceChristian[indexaccount] = BalanceChristian[indexaccount] - amount;
                                                        Console.WriteLine(Christian[indexaccount]);
                                                        Console.WriteLine(BalanceChristian[indexaccount] + " kr");
                                                                                                                   
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Neo")
                                            {
                                                for (int j = 0; j < Neo.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Neo[j]);
                                                    Console.WriteLine(": " + BalanceNeo[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du ta ut pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceNeo[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du ta ut? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        Console.WriteLine("Här är de nya saldot");
                                                        BalanceNeo[indexaccount] = BalanceNeo[indexaccount] - amount;
                                                        Console.WriteLine(Neo[indexaccount]);
                                                        Console.WriteLine(BalanceNeo[indexaccount] + " kr");

                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }
                                            if (User == "Jennie")
                                            {
                                                for (int j = 0; j < Jennie.Length; j++)
                                                {
                                                    Console.Write("[" + j + "]" + Jennie[j]);
                                                    Console.WriteLine(": " + BalanceJennie[j] + " kr");
                                                }

                                                try
                                                {
                                                    Console.WriteLine("Vilket konto vill du ta ut pengar från? (ange siffran som står inom[])");
                                                    int indexaccount = Convert.ToInt32(Console.ReadLine());
                                                    try
                                                    {
                                                        Console.WriteLine(BalanceJennie[indexaccount]);
                                                        Console.WriteLine("Hur mycket vill du ta ut? ");
                                                        double amount = Convert.ToDouble(Console.ReadLine());

                                                        Console.WriteLine("Här är de nya saldot: ");
                                                        BalanceJennie[indexaccount] = BalanceJennie[indexaccount] - amount;
                                                        Console.WriteLine(Jennie[indexaccount]);
                                                        Console.WriteLine(BalanceJennie[indexaccount] + " kr");


                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("Du måste ange en giltig siffra");
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Du måste ange en giltig siffra");
                                                }


                                            }

                                            break;
                                        case 4:
                                            Console.WriteLine("Logga ut");
                                            MenyBool = false;
                                            MinBool = true;
                                            i = 3;
                                            break;
                                        default:
                                            Console.WriteLine("Du har angivit ett ogiltigt menyval");
                                            break;
                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("Fel pinkod försök igen");
                            }
                        if (i==2)
                        {
                        Console.WriteLine("Du har angivit fel pinkod 3 gånger");
                        MinBool = false;
                        }

                        }
                        
                    }
                }
            }
        }
    
        //Metod
        static string checkLoggin()
        {

        //        var Users = new List<string> { "Daniel", "Martin", "Christian", "Neo", "Jennie" };//https://channel9.msdn.com/Series/CSharp-101/CSharp-Sort-Search-and-Index-Lists                
        //        string[] Passwords = { "1234", "2345", "3456", "4567", "5678" };
        Console.Write("Var god ange ditt användarnamn: ");
        string User = Console.ReadLine();
        return User;
        //        var index = Users.IndexOf(User);
        //        bool MinBool = true;
        //        while (MinBool)
        //        {

        //            foreach (var item in Users)
        //            {
        //                if (User == item)
        //                {
        //                    Console.WriteLine("Hej! " + Users[index]);

        //                    for (int i = 0; i < 3; i++)
        //                    {
        //                        Console.Write("Var god ange din pinkod: ");
        //                        string GivenPassword = Console.ReadLine();

        //                        if (GivenPassword == Passwords[index])
        //                        {
        //                            break;
        //                        }
        //                        else if (GivenPassword != Passwords[index])
        //                        {
        //                            Console.WriteLine("Fel pinkod försök igen");
        //                        }

        //                    }
        //                    MinBool = false;

        //                }

        //            }

        //        }
        //        return User;
        //    }

        }

        
    }
}
