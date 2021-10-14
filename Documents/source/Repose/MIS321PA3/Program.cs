using System;
using MIS321PA3;
using MIS321PA3.Database;
using MIS321PA3.Models;

namespace MIS321PA3
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice= GetMenuChoice(); //priming read 

            while(choice != "6")
            {
                if(choice == "1")
                {
                    Console.WriteLine("View all posts");
                    Utility.PrintData();

                    
                }
                else if(choice == "2")
                {
                    Console.WriteLine("Add a post");
                    Utility.AddPost();
                    
                }
                else if(choice == "3")
                {
                    Console.WriteLine("Delete a post");
                    Utility.DeleteEntry();
                    
                }
                else if(choice == "4")
                {
                    Console.WriteLine("Edit a post");
                    Utility.EditPost();
                }
                else if(choice == "5")
                {
                    Console.WriteLine("Reseed Data");
                    Utility.ReseedData();
                }
                else 
                {
                    Console.WriteLine("Invalid Choice");
                }
                //update read
                choice = GetMenuChoice();
            }

            static string GetMenuChoice()
            {
                //display menu, user enter choice, send back to main 
                // \n is a new line \t is a tab over
                Console.WriteLine("Enter any key to move forward");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(" \n1. See all posts ");
                Console.WriteLine("2. Add post");
                Console.WriteLine("3. Delete Post");
                Console.WriteLine("4.Edit Post");
                Console.WriteLine("5.Reseed Data");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your Choice");
                string choice = Console.ReadLine();

                return choice;
            }
        }
    }
}
