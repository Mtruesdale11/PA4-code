using MIS321PA3;
using System;
using MIS321PA3.Database;
using MIS321PA3.Models;
using MySql.Data.MySqlClient;
using MIS321PA3.Interface;
using MIS321PA3.Interfaces;


namespace MIS321PA3.Database
{
    
    public class SavePost : ISavePosts
    {
        
        public static void CreatePostTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE posts(id INTEGER PRIMARY KEY AUTO_INCREMENT, PostTxt TEXT, PostDate DATE)";

            using var cmd = new MySqlCommand(stm,con);

            cmd.ExecuteNonQuery();
        }

        public void CreatePost(Posts myPost)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO posts(PostTxt,PostDate) VALUES (@PostTxt,@PostDate)";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@PostTxt",myPost.PostTxt);
            cmd.Parameters.AddWithValue("@PostDate",myPost.PostDate);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void SavePosts(Posts myPost)
        {
            throw new System.NotImplementedException();
        }
        public void SavePosts(int id)
        {
            throw new System.NotImplementedException();
        }

        
    }
}