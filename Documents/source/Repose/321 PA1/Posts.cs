using System;
namespace _321_PA1
{
    public class Posts
    {
        public string PostID{get;set;}

        public string PostTxt{get;set;}

        public string PostDate{get;set;}

        public int CompareTo(Posts temp)
        {
            return this.PostID.CompareTo(temp.PostID);
        }

        public static int CompareByDate(Posts x, Posts y)
        {
            return x.PostDate.CompareTo(y.PostDate);
        }

        public override string ToString()
        {
            return this.PostID+ " " + this.PostTxt + " " + this.PostDate;
        }
        
    }
}