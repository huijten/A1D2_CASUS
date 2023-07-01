using A1D2_CASUS.Model;
using A1D2_CASUS.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A1D2_CASUS.DAO
{
    public class FeedBackDAO
    {
        //Kevin
        //private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
        //Ruben
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
        //Wien
        private string connectionString = @"Server=DESKTOP-TJRHV75; Database=Gamification; Trusted_Connection=True";

        #region CRUD

        FeedBase feedbase { get; set; }
        internal DataTable GetFeedbackFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * From FeedBack"; 
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

        public void CreateFeedBack( FeedBase FeedBaseId, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedBack( FeedBaseId, Notes) VALUES (@FeedBaseId, @note)";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedBaseId", FeedBaseId); 
                        command.Parameters.AddWithValue("@note", note);   
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void Insert(FeedBack feedback)
        {
            FeedBaseDAO db = new FeedBaseDAO();
            var Feedbase = InsertAndReturnId(feedbase);
            feedback.FeedBaseId = feedbase;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO FeedBack VALUES(@feedItemId, @notes)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@feedbaseId", feedback.FeedBaseId);
                        command.Parameters.AddWithValue("@notes", feedback.Notes);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

        }
        public int InsertAndReturnId(FeedBase feedbase)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO FeedBase OUTPUT INSERTED.ID VALUES(@creationDate, @completed, @approvedBy, @assignmentId, @supervisorId, @studentId, @contents)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@creationDate", feedbase.CreationDate);
                        command.Parameters.AddWithValue("@approvedBy", feedbase.ApprovedBy);
                        command.Parameters.AddWithValue("@assignmentId", feedbase.Assignment);
                        command.Parameters.AddWithValue("@studentId", feedbase.Student);
                        command.Parameters.AddWithValue("@contents", feedbase.Content);
                        int modified = (int)command.ExecuteScalar();
                        return modified;
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }
            
        }
        #endregion

        #region Getting all Feedbacks from database
        public List<FeedBack> Read()
        {
            List<FeedBack> feedbacks = new List<FeedBack>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, FeedBaseId, Notes FROM FeedBack";

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
        public void GetFeedbackBaseId(int id)
        {
            List<FeedBack> fedbacks = new List<FeedBack> { };
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM FeedBack WHERE FeedBaseId = @FeedBaseId";
                    command.Parameters.AddWithValue("@FeedBaseId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FeedBack fedback = new FeedBack(Int32.Parse(reader[0].ToString()), feedbase,
                                reader[2].ToString());
                            fedbacks.Add(fedback);
                        }
                    }
                }
            }
        }
    }
}
