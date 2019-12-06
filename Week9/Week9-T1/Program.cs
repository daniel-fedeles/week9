using System.Configuration;

namespace Week9_T1
{
    class Program
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["week9t1"].ConnectionString;
        private static DbConnection dbCon = new DbConnection(connectionString);
        static void Main(string[] args)
        {

            var con = dbCon.ConnectToDb();

            PublisherSql pub = new PublisherSql();
            pub.InsertNewPublisher(con);
        }
    }
}
