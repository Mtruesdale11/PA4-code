using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _321_PA1
{
    public class PostUtil
    {
        public static void PrintAllPosts(List<Posts> posts)
        {
            foreach(Posts post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        public static void AddPost()
        {
         string filePath = "posts.txt";
         List<string> lines = new List<string>();
         lines = File.ReadAllLines(filePath).ToList();   

         foreach(string line in lines)
         {
             Console.WriteLine(line);
         }
         Console.WriteLine("Enter post in format of Post Number#Post Text#Post Date");
         lines.Add(Console.ReadLine());
         File.WriteAllLines(filePath,lines);

         Console.ReadLine();
         return;
        }

        public static void DeletePost()
        {  
            Console.WriteLine("Enter post ID number that needs to be removed");
            string line = null;
            int lineNumber = 0;
            int lineToDelete = int.Parse(Console.ReadLine());
            using(StreamReader reader = new StreamReader("posts.txt"))
            {
                using(StreamWriter writer = new StreamWriter("Posts.txt"))
                {
                    while((line = reader.ReadLine()) !=null)
                    {
                        lineNumber++;
                    }
                    if(lineNumber==lineToDelete)
                    {
                      
                    }
                }
            }
        }
    }
}