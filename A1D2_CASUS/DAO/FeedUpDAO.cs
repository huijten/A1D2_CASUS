using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedUpDAO
    {
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";

        #region Getting all FeedUps from database
        public List<FeedUp> Read()
        {
            List<FeedUp> feedups = new List<FeedUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Feed, Priority, Reflection FROM FeedUp";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int feedBaseId = reader.GetInt32(1);
                            int priority = reader.GetInt32(2);
                            string reflection = reader.GetString(3);

                            // Get FeedBase by FeedId                            
                            FeedBase feed = new FeedBase();

                            FeedUp feedup = new FeedUp(id, feed.Search(feedBaseId), priority, reflection);
                            feedups.Add(feedup);
                        }
                    }
                }
            }

            return feedups;
        }
    }
    #endregion
}
