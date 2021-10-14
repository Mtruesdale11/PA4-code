using MIS321PA3;
using System;
using MIS321PA3.Interface;
using MIS321PA3.Interfaces;
using MIS321PA3.Database;
namespace MIS321PA3.Models
{
    public class Posts
    {
        public int id{get;set;}
        public string PostTxt{get;set;}
        public string PostDate{get;set;}
        public char value {get;set;}

        public ISavePosts Save {get;set;}
        public IUpdatePosts Update {get;set;}

        public Posts()
        {
            Save = new SavePost();
            Update = new UpdatePost();
        }
        public override string ToString()
        {
            return "Post: " + id + " " + PostTxt + " " + PostDate;
        }
        

    }
}