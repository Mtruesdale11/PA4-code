using System;
using MIS321PA3;
using MIS321PA3.Database;
using MIS321PA3.Interface;
using MIS321PA3.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using MIS321PA3.Interfaces;

namespace MIS321PA3.Models
{
    public class Utility
    {
        public static void AddPost()
        {
            string PostTxt;
            string PostDate;
            Console.WriteLine("What would you like the post to say?");
            PostTxt =Console.ReadLine();
            Console.WriteLine("What is the date today? Enter as YYYY-MM-DD");
            PostDate = Console.ReadLine();
            Posts myPost = new Posts(){PostTxt = PostTxt, PostDate = PostDate};
            myPost.Save.CreatePost(myPost);

        }

        public static void EditPost()
        {
            int id;
            string PostTxt;
            string PostDate;
            Console.WriteLine("What is the ID of the post you would like to update?");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like the post to say?");
            PostTxt =Console.ReadLine();
            Console.WriteLine("What is the date today? Enter as YYYY-MM-DD");
            PostDate = Console.ReadLine();
            //create new post & pass in 
            Posts myPost = new Posts(){id = id, PostTxt = PostTxt, PostDate = PostDate};
            UpdatePost.UpdateData(myPost);
            
        }

        public static void DeleteEntry()
        {
            int id;
            Console.WriteLine("What is the ID number of the post you would like to delete?");
            id = int.Parse(Console.ReadLine());
            DeletePost.DeleteData(id);
        }

        public static void ReseedData()
        {
            string PostTxt;
            string PostDate;
            Console.WriteLine("Droping table for data Reseed");
            Console.WriteLine("What would you like the post to say?");
            PostTxt =Console.ReadLine();
            Console.WriteLine("What is the date today? Enter as YYYY-MM-DD");
            PostDate = Console.ReadLine();
            DeletePost.DropPostTable();
            SavePost.CreatePostTable();
            Posts myPost = new Posts(){PostTxt = PostTxt, PostDate = PostDate};
            myPost.Save.CreatePost(myPost);
        }

        public static void PrintData()
        {
            IReadData readObject = new ReadData();
            List<Posts> allPosts = readObject.GetAllPosts();

            foreach(Posts post in allPosts)
            {
                Console.WriteLine(post.ToString());
            }
            

        }
    }    
}       

     
