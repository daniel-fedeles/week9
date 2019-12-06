using System;
using System.Data.SqlClient;

namespace SummaryPublisherApp
{
    public class PublisherSQL
    {
        public void GetNrOfRows(SqlConnection con)
        {
            using (con)
            {
                var cmdq = "select count(*) from Publisher";

                using (SqlCommand command = new SqlCommand(cmdq, con))
                {
                    var x = command.ExecuteScalar();
                    Console.WriteLine($"{x} rows are in Publishet table");
                }

            }
        }

        public void Getop10Publishers(SqlConnection con)
        {
            using (con)
            {
                var cmdq = "select top(10) PublisherId, Name from Publisher";

                using (SqlCommand command = new SqlCommand(cmdq, con))
                {
                    var x = command.ExecuteReader();
                    while (x.Read())
                    {
                        Console.WriteLine($"PublisherId = {x["PublisherId"]} Name = {x["Name"]}");
                    }
                }

            }
        }

        public void GetNrOfBooksForEachPublisher(SqlConnection con)
        {
            using (con)
            {
                var cmdq = "SELECT Name, COUNT(BookId) AS NrOfBooks FROM Publisher join Book on Book.PublisherId=Publisher.PublisherId group by (Name)";

                using (SqlCommand command = new SqlCommand(cmdq, con))
                {
                    var x = command.ExecuteReader();
                    while (x.Read())
                    {
                        Console.WriteLine($"Name = {x["Name"]} \t\t NrOfBooks = {x["NrOfBooks"]}");
                    }
                }

            }
        }

        public void GetNrOfBooksAndPriceForEachPublisher(SqlConnection con)
        {
            using (con)
            {
                var cmdq = "SELECT Name, COUNT(BookId) AS NrOfBooks, SUM(Price) AS TotalPrice FROM Publisher join Book on Book.PublisherId=Publisher.PublisherId group by (Name)";

                using (SqlCommand command = new SqlCommand(cmdq, con))
                {
                    var x = command.ExecuteReader();
                    while (x.Read())
                    {
                        Console.WriteLine($"Name = {x["Name"]} \t\t NrOfBooks = {x["NrOfBooks"]} \t\t TotalPrice = {x["TotalPrice"]}");
                    }
                }

            }
        }
    }
}