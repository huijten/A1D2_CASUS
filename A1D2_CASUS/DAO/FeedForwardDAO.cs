using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedForwardDAO
    {
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";

        #region Getting all FeedForwards from database
        public List<FeedForward> Read()
        {
            List<FeedForward> feedforwards = new List<FeedForward>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Feed, Notes FROM FeedForward";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int feedBaseId = reader.GetInt32(1);
                            string notes = reader.GetString(2);

                            // Get FeedBase by FeedId                            
                            FeedBase feed = new FeedBase();

                            FeedForward feedforward = new FeedForward(id, feed.Search(feedBaseId), notes);
                            feedforwards.Add(feedforward);
                        }
                    }
                }
            }

            return feedforwards;
        }
    }
    #endregion
}
}
