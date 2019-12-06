using System.Data.SqlClient;

namespace SummaryPublisherApp
{
    public class DbCon
    {
        public DbCon(string connectionString)
        {
            this.ConString = connectionString;
        }

        private string ConString;

        public SqlConnection ConnectToDb()
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            return con;
        }
    }
}