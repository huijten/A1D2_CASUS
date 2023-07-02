using A1D2_CASUS.Model;
using A1D2_CASUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedForwardDAO : Constring
    {

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
        #endregion

        #region Creating FeedForward
        public void Create(FeedForward feedForward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedForward (Feed, Notes) VALUES (@Feed, @Notes)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Feed", feedForward.Feed.Id);
                        command.Parameters.AddWithValue("@Notes", feedForward.Notes);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void EditFF(int id, FeedBase Feed, string Notes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedForward SET Feed = @Feed, Notes = @Notes WHERE id = @Id ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Feed", Feed.Id);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void Delfff(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FeedForward WHERE Id = @Id";
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
        #endregion

        #region Datatable
        internal DataTable GetDataTables()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT f.Id, f.Feed, f.Notes, fb.Id, fb.CreationDate, fb.ApprovedById, fb.AssignmentId, fb.StudentId, fb.Content FROM FeedForward f JOIN FeedBase fb ON f.Feed = fb.Id"; ;
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

