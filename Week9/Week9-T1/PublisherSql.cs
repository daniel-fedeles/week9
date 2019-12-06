using System;
using System.Data.SqlClient;

namespace Week9_T1
{
    public class PublisherSql
    {
        public void InsertNewPublisher(SqlConnection con)
        {
            using (con)
            {
                var cmdq = "insert into Publisher values('@Name') select scope_identity()";

                Console.WriteLine("Read Name: ");

                string paramValue = Console.ReadLine();

                using (SqlCommand command = new SqlCommand(cmdq, con))
                {
                    command.Parameters.AddWithValue("@Name", paramValue);
                    var x = command.ExecuteScalar();
                    Console.WriteLine($"Last inserted id is: {x} and it belongs to {paramValue}");
                }

            }
        }

    }
}