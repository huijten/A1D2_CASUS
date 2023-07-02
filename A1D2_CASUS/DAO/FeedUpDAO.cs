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
    public class FeedUpDAO : Constring
    {
        #region Getting all FeedUps from database
        internal DataTable GetFups()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT f.Id, f.Feed, f.Priority, f.Reflection, fb.Id, fb.CreationDate, fb.ApprovedById, fb.AssignmentId, fb.StudentId, fb.Content FROM FeedUp f JOIN FeedBase fb ON f.Feed = fb.Id"; ;
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
        public void CreateFup(FeedUp feedup)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedUp (Feed, Priority, Reflection) VALUES (@Feed, @Priority, @Reflection)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Feed", feedup.Feed.Id);
                        command.Parameters.AddWithValue("@Priority", feedup.Priority);
                        command.Parameters.AddWithValue("@Reflection", feedup.Reflection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void EditFU(int id, FeedBase Feed, int Priority, string Reflection)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedUp SET Feed = @Feed, Priority = @Priority, Reflection = @Reflection WHERE id = @Id ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Feed", Feed.Id);
                        command.Parameters.AddWithValue("@Priority", Priority);
                        command.Parameters.AddWithValue("@Reflection", Reflection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void DelFU(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FeedUp WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }
    #endregion
}
