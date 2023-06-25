using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
        FeedBase feedy;
        Assignment assignment;
        Student Student;
        private string tableName = "FeedBase";

        internal int GetLastFeedId()
        {
            int ID = new int();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(Id) FROM FeedBase";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        {
                            ID = reader.GetInt32(0);
                        }
                    }
                }
                return ID;
            }
        }
        internal int GetLastFeedItem()
        {
            int ID = new int();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(Id) FROM FeedBase ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            
                        }
                    }
                }
                return ID;
            }
        }
        internal DataTable GetFeedBaseFromDatabase()
        {
            DataTable datafeedTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * From FeedBase"; ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(datafeedTable);
                    }
                }
            }

            return datafeedTable;
        }
        
        internal void CreateFeedbase(DateTime creationDate, Assignment AssignmentId, Student student, string content)
        {
            Assignment asg = new Assignment();
            asg.Id = this.AssignmentId;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    
                    string sql = "INSERT INTO FeedBase (creationDate, AssignmentId,  student, content) VALUES (@CreationDate, @AssignmentId,   @StudentId, @Content)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CreationDate", creationDate);
                        command.Parameters.AddWithValue("@AssignmentId", AssignmentId);
                       // command.Parameters.AddWithValue("@SupervisorId", approvedBy);
                      //  command.Parameters.AddWithValue("@ApprovedById", approvedBy);
                        
                        command.Parameters.AddWithValue("@StudentId", student);
                        command.Parameters.AddWithValue("@Content", content); 
                        command.ExecuteNonQuery();
                    }
                }
            }
           
            catch (SqlException ex) { throw ex; }
        }

        public void Insert(FeedBase feeditem, Boolean refreshData = false)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO " + tableName + " VALUES(@SupervisorId, @CreationDate,  @ApprovedById,   @StudentId, @Content)", connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@creationDate", feeditem.CreationDate);
                        
                        command.Parameters.AddWithValue("@ApprovedById", feeditem.Supervisor);
                        command.Parameters.AddWithValue("@assignmentId", feeditem.Assignment);
                        command.Parameters.AddWithValue("@supervisorId", feeditem.Supervisor);
                        command.Parameters.AddWithValue("@studentId", feeditem.Student);
                        command.Parameters.AddWithValue("@content", feeditem.Content);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException error) { throw error; }
                    finally { connection.Dispose(); }
                }
            }

        }
        internal void CreateFeedbaze(FeedBase feedbase)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Feedbase (creationDate,  assignmentid, ApprovedByid, studentid, content) VALUES (@CreationDate, @AssignmentId, @ApprovedById ,@StudentId, @Content)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CreationDate", feedbase.CreationDate);
                        command.Parameters.AddWithValue("@AssignmentId", feedbase.Assignment);
                        // command.Parameters.AddWithValue("@SupervisorId", approvedBy);
                          command.Parameters.AddWithValue("@ApprovedById", feedbase.ApprovedBy);

                        command.Parameters.AddWithValue("@StudentId", feedbase.Student);
                        command.Parameters.AddWithValue("@Content", feedbase.Content);
                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (SqlException ex) { throw ex; }
        }
        internal void UpdateFeedBack(int id, DateTime creationDate, Supervisor approvedBy, Assignment assignment, Student student, string content)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE FeedBack SET Feed = @Feed, Notes = @Notes, Bonuspoints = @Bonuspoints WHERE id = @Id ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                       // command.Parameters.AddWithValue("@Id", id);
                        //command.Parameters.AddWithValue("@Feed", Feed);
                        //command.Parameters.AddWithValue("@Notes", Notes);
                        //command.Parameters.AddWithValue("@Bonuspoints", Bonuspoints);
                       // command.ExecuteNonQuery();
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
                    cmd.CommandText = "SELECT Id, CreationDate, ApprovedById, AssignmentId, StudentId, Content WHERE Id = @FeedBaseId";
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
    }
}
