using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class AssignmentDAO
    {
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";

        #region Search
        public Assignment Search(int assignmentId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, Deadline, isCompleted, Points WHERE Id = @AssignmentId";
                    cmd.Parameters.AddWithValue("@AssignmentId", assignmentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Assignment> assignments = new List<Assignment>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            bool isCompleted = reader.GetBoolean(3);
                            int points = reader.GetInt32(4);

                            Assignment assignment = new Assignment(id, name, date, isCompleted, points);
                            assignments.Add(assignment);
                        }

                        return assignments.FirstOrDefault(); // Return the first student found (or null if not found)
                    }
                }
            }
        }
        #endregion
    }
}
