using System; 
using MIS321PA3.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MIS321PA3.Interface;

namespace MIS321PA3.Database
{
    public class DeletePost : IDeletePosts
    {
        public static void DropPostTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS posts";

            using var cmd = new MySqlCommand(stm,con);

            cmd.ExecuteNonQuery();
        }
        public static void DeleteData(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DELETE FROM posts WHERE id = @id";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        void IDeletePosts.DeletePost(int id)
        {
            throw new NotImplementedException();
        }
    }
}