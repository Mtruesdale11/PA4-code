using MIS321PA3.Interfaces;
using System;
using MIS321PA3.Interface;
using MIS321PA3.Models;
using MySql.Data.MySqlClient;

namespace MIS321PA3.Database
{
    public class UpdatePost : IUpdatePosts, ISavePosts
    {
        public void CreatePost(Posts myPost)
        {
            throw new System.NotImplementedException();
        }

        public void SavePosts(Posts myPost)
        {
            throw new System.NotImplementedException();
        }
        public static void UpdateData(Posts value)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE posts set PostTxt=@PostTxt, PostDate=@PostDate WHERE id = @id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value.id);
            cmd.Parameters.AddWithValue("@PostTxt",value.PostTxt);
            cmd.Parameters.AddWithValue("@PostDate",value.PostDate);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        void IUpdatePosts.UpdatePost(Posts value)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE posts set PostTxt=@PostTxt, PostDate=@PostDate WHERE id = @id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",value.id);
            cmd.Parameters.AddWithValue("@PostTxt",value.PostTxt);
            cmd.Parameters.AddWithValue("@PostDate",value.PostDate);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}