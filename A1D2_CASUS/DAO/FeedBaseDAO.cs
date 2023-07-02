using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedBaseDAO : Constring
    {
        internal void CreateFBS(FeedBase feedbas)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedBase (CreationDate, ApprovedById, AssignmentId, StudentId, content) VALUES (@CreationDate, @ApprovedBy, @AssignmentId, @StudentId, @Content)";
                    
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))

                    {
                        command.Parameters.AddWithValue("@CreationDate", feedbas.CreationDate);
                        command.Parameters.AddWithValue("@ApprovedBy", feedbas.ApprovedBy.Id);
                        command.Parameters.AddWithValue("@AssignmentId", feedbas.Assignment.Id);
                        command.Parameters.AddWithValue("@StudentId", feedbas.Student.Id);
                        command.Parameters.AddWithValue("@Content", feedbas.Content);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        #region Search Database
        public FeedBase Search(int feedBaseId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, CreationDate, ApprovedById, AssignmentId, StudentId, Content FROM FeedBase WHERE Id = @FeedBaseId";
                    cmd.Parameters.AddWithValue("@FeedBaseId", feedBaseId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<FeedBase> feedbases = new List<FeedBase>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            DateTime date = reader.GetDateTime(1);
                            string content = reader.GetString(5);

                            int SupervisorId = reader.GetInt32(2);
                            Supervisor supervisor = new Supervisor();

                            int AssignmentId = reader.GetInt32(3);
                            Assignment assignment = new Assignment();

                            int studentId = reader.GetInt32(4);
                            Student student = new Student();

                            FeedBase feed = new FeedBase(id, date, supervisor.Search(SupervisorId), 
                                assignment.Search(AssignmentId), student.Search(studentId), content);
                        }

                        return feedbases.FirstOrDefault(); // Return the first student found (or null if not found)
                    }
                }
            }
        }

        #endregion

        #region Search Database by assignment
        public FeedBase SearchByAssignment(int assignmentId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, CreationDate, ApprovedById, AssignmentId, StudentId, Content FROM FeedBase WHERE AssignmentId = @assignmentId";
                    cmd.Parameters.AddWithValue("@assignmentId", assignmentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<FeedBase> feedbases = new List<FeedBase>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            DateTime date = reader.GetDateTime(1);
                            string content = reader.GetString(5);

                            int SupervisorId = reader.GetInt32(2);
                            Supervisor supervisor = new Supervisor();

                            int AssignmentId = reader.GetInt32(3);
                            Assignment assignment = new Assignment();

                            int studentId = reader.GetInt32(4);
                            Student student = new Student();

                            FeedBase feed = new FeedBase(id, date, supervisor.Search(SupervisorId),
                                assignment.Search(AssignmentId), student.Search(studentId), content);
                            feedbases.Add(feed);
                        }

                        return feedbases.FirstOrDefault(); // Return the first student found (or null if not found)
                    }
                }
            }
        }

        #endregion
    }
}
