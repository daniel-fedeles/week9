using System.Configuration;

namespace SummaryPublisherApp
{
    class Program
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["week9t1"].ConnectionString;
        private static DbCon dbCon = new DbCon(connectionString);
        static void Main(string[] args)
        {
            var con = dbCon.ConnectToDb();
            PublisherSQL pbSql = new PublisherSQL();
            //            pbSql.GetNrOfRows(con);
            //            pbSql.Getop10Publishers(con);
            //            pbSql.GetNrOfBooksForEachPublisher(con);
            pbSql.GetNrOfBooksAndPriceForEachPublisher(con);
        }
    }
}
