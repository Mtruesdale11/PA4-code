using System;
using System.Collections.Generic;
using MIS321PA3;
using MIS321PA3.Database;
using MIS321PA3.Models;
using MySql.Data.MySqlClient;
namespace MIS321PA3.Interfaces
{
    public interface IReadData
    {
        public List<Posts> GetAllPosts(); 
    }
}