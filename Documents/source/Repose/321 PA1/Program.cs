using System.Collections.Generic;
using System;

namespace _321_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice= GetMenuChoice(); //priming read 

            while(choice != "4")
            {
                if(choice == "1")
                {
                    Console.WriteLine("View all posts");

                    List<Posts> twitterPosts = PostFile.GetPosts();

                    twitterPosts.Sort(Posts.CompareByDate);
                    Console.WriteLine("");
                    Console.WriteLine("Sorted By Post Date");
                    PostUtil.PrintAllPosts(twitterPosts);

                    
                }
                else if(choice == "2")
                {
                    Console.WriteLine("Add a post");
                    PostUtil.AddPost();
                }
                else if(choice == "3")
                {
                    Console.WriteLine("Delete a post");
                    PostUtil.DeletePost();
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
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your Choice");
                string choice = Console.ReadLine();

                return choice;
            }
        
        }
    }
}
