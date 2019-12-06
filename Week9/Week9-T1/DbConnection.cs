using System.Data.SqlClient;

namespace Week9_T1
{
    public class DbConnection
    {
        public DbConnection(string connectionString)
        {
            this.ConString = connectionString;
        }

        public string ConString { get; }

        public SqlConnection ConnectToDb()
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            return con;
        }
    }
}