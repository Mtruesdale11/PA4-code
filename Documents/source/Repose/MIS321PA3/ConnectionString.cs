using MIS321PA3;
namespace MIS321PA3.Database
{
    public class ConnectionString
    {
        public string cs {get;set;}

        public ConnectionString()
        {
            string server = "en1ehf30yom7txe7.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "rqiwlb7j2giwm275";
            string port = "3306";
            string userName = "k85zgu8b6zodro70";
            string password = "dvn15v2mxcch2iy6";

            cs = $@"server = {server};user = {userName};database = {database};port = {port};password = {password};";
        }
    }
}