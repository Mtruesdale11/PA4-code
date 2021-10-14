using System;
using MIS321PA3.Models;
namespace MIS321PA3.Interface
{
    public interface ISavePosts
    {
         public void CreatePost(Posts myPost);
         public void SavePosts(Posts myPost);
    }
}