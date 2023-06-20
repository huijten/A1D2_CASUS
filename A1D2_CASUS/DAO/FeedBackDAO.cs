using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedBackDAO
    {
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";

        #region Getting all Feedbacks from database
        public List<FeedBack> Read()
        {
            List<FeedBack> feedbacks = new List<FeedBack>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT f.Id AS FeedId, f.CreationDate, " +
                        "f.Content, ff.Id AS FeedbackId, ff.Notes FROM FeedBase f " +
                        "JOIN FeedForward ff ON f.Id = ff.FeedId";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FeedBase feedBase = new FeedBase();
                            feedBase.Id = Convert.ToInt32(reader["FeedId"]);
                            feedBase.CreationDate = Convert.ToDateTime(reader["CreationDate"]);
                            feedBase.Content = Convert.ToString(reader["Content"]);

                            FeedBack feedback = new FeedBack();
                            feedback.Id = Convert.ToInt32(reader["FeedbackId"]);
                            feedback.Feed = feedBase;
                            feedback.Notes = Convert.ToString(reader["Notes"]);

                            feedbacks.Add(feedback);           
                        }
                    }
                }
            }

            return feedbacks;
        }
    }
    #endregion
}
