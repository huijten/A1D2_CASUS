using A1D2_CASUS.Model;
using A1D2_CASUS.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{

    public class FeedBackDAO
    {
        //Kevin
        //private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
        //Ruben
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
        //Wien
        private string connectionString = @"Server=.; Database=Gamification; Trusted_Connection=True";

        #region C.R.U.D
        internal DataTable GetFeedbackFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * From FeedBack"; ;
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
        internal void CreateFeedback(FeedBack feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedBack (Assignment, Notes, Bonuspoints) VALUES (@Assignment, @Notes, @Bonuspoints)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Assignment", feedback.assignment);
                        command.Parameters.AddWithValue("@Notes", feedback.Notes);
                        command.Parameters.AddWithValue("@Bonuspoints", feedback.Bonuspoints);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void UpdateFeedBack(int id, FeedBase Feed, string Notes, int Bonuspoints)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedBack SET Feed = @Feed, Notes = @Notes, Bonuspoints = @Bonuspoints WHERE id = @Id ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Feed", Feed);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@Bonuspoints", Bonuspoints);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void DeleteFeedback(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FeedBack WHERE id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }


        #endregion


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

                            //FeedBack feedback = new FeedBack( notes);
                           // feedbacks.Add(feedback);
                        }
                    }
                }
            }

            return feedbacks;
        }
    }
    #endregion
}
