using MIS321PA3.Database;
using System;
using MIS321PA3.Interface;
using MIS321PA3.Interfaces;
using MIS321PA3.Models;
using MySql.Data.MySqlClient;
using MIS321PA3;
using System.Collections.Generic;
namespace MIS321PA3.Database

{
    public class ReadData : IReadData
    {
            public List<Posts> GetAllPosts()
        {

            List<Posts> allPosts = new List<Posts>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM posts order by PostDate desc"; 
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                allPosts.Add(new Posts(){id = rdr.GetInt32(0),PostTxt =rdr.GetString(1),PostDate=rdr.GetString(2)});
    
            }

            


            return allPosts;
        }
    }
}