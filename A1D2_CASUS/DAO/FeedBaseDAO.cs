using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A1D2_CASUS.DAO
{
    public class FeedBaseDAO
    {
        //Kevin
        //private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
        //Ruben
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
        //Wien
        private string connectionString = @"Server=.; Database=Gamification; Trusted_Connection=True";

        #region CRUD
        internal DataTable GetFeedbaseFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * From FeedBase"; ;
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
        internal void CreateFeedbase(FeedBase feedbase)//, Assignment assignment, Supervisor approvedby, Student student
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedBase (AssignmentId, ApprovedById, StudentId, creationDate, Content) VALUES (@AssignmentId, @ApprovedById, @StudentId, @CreationDate, @Content)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentId", feedbase.Assignment.Id);
                        command.Parameters.AddWithValue("@ApprovedById", feedbase.ApprovedBy.Id);
                        command.Parameters.AddWithValue("@StudentId", feedbase.Student.Id);
                        command.Parameters.AddWithValue("@CreationDate", feedbase.CreationDate);
                        command.Parameters.AddWithValue("@Content", feedbase.Content);
                        command.ExecuteNonQuery();
     
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        internal void UpdateFeedbase(int id, DateTime CreationDate, Supervisor approvedby, Assignment assignment, Student student, string content)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = "UPDATE FeedBase SET AssignmentId = @AssignmentId,  ApprovedById = @ApprovedById , StudentId= @StudentId, CreationDate =  @CreationDate, Content = @Content WHERE id = @Id ";
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@AssignmentId", assignment.Id);
                            command.Parameters.AddWithValue("@ApprovedById", approvedby.Id);
                            command.Parameters.AddWithValue("@StudentId", student.Id);
                            command.Parameters.AddWithValue("@CreationDate", CreationDate);
                            command.Parameters.AddWithValue("@Content", content);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex) { throw ex; }
            }
        }
        internal void DeletFeedBase(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FeedBase WHERE id = @Id";
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
