using System;
using System.Collections.Generic;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter userCharacter = GetUserCharacter();
            Fighter computerCharacter = GetUserCharacter();
            Battle.StartFight(userCharacter,computerCharacter);
         
        }

            public static Fighter GetUserCharacter()
            {   
                Fighter userCharacter = new Fighter();

                Console.WriteLine(" \n1. Choose Ronald");
                Console.WriteLine("2. Choose Hamburgler");
                Console.WriteLine("3. Choose Fry Kids");
                Console.WriteLine("Enter your Choice");
                string choice = Console.ReadLine();
                while(choice != "4")
                {
                    if(choice == "1")
                    {
                        userCharacter = new Ronald();
                        choice ="4";
                    }
                    else if(choice == "2")
                    {
                        userCharacter = new Hamburgler();
                        choice ="4";

                    }
                    else if(choice == "3")
                    {
                        userCharacter = new FryKids();
                        choice="4";
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                    return userCharacter;
            }    
            

        }
    }