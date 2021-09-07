using System.IO;
using System;
using System.Collections.Generic;

namespace _321_PA1
{
    public class PostFile
    {
        public static List<Posts> GetPosts()
        {
            List<Posts> twitterPosts = new List<Posts>();
            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Something went Wrong...returning list {0}",e);
                return twitterPosts;
            }

            string line = inFile.ReadLine();
            while(line !=null)
            {
                string[] temp = line.Split('#');
                DateTime date = DateTime.Parse(temp[2]);
                twitterPosts.Add(new Posts(){PostID =temp[0],PostTxt = temp [1], PostDate = date.ToString()});

                line = inFile.ReadLine();
            }

            inFile.Close();

            return twitterPosts;

        }
    }
}