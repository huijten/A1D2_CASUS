using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedBackDAO : Constring
    {
        #region Getting all Feedbacks from database
        public List<FeedBack> Read()
        {
            List<FeedBack> feedbacks = new List<FeedBack>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Feed, Notes FROM FeedBack";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int feedbackId = reader.GetInt32(0);
                            int feedBaseId = reader.GetInt32(1);
                            string notes = reader.GetString(2);

                            // Get FeedBase by FeedId                            
                            FeedBase feed = new FeedBase();

                            FeedBack feedback = new FeedBack(feedbackId, feed.Search(feedBaseId), notes);
                            feedbacks.Add(feedback);
                        }
                    }
                }
            }

            return feedbacks;
        }
        #endregion
#region CRUD

        internal void ApplyFeedback(FeedBack feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedBack (Feed, Notes) VALUES (@Feed, @Notes)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Feed", feedback.Feed.Id);
                        command.Parameters.AddWithValue("@Notes", feedback.Notes);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        #endregion
        #region Datatable
        internal DataTable GetFeedBackDataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT f.Id, f.Feed, f.Notes, fb.Id, fb.CreationDate, fb.ApprovedById, fb.AssignmentId, fb.StudentId, fb.Content FROM FeedBack f JOIN FeedBase fb ON f.Feed = fb.Id"; ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        #endregion
    }
}
