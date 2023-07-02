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
    public class SupervisorDAO : Constring
    {

        internal DataTable GetSupervisorsFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Supervisor"; 
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
        public bool Validatecred(string WorkNumber, string Password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Supervisor WHERE WorkNumber = @WorkNumber AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WorkNumber", WorkNumber);
                    command.Parameters.AddWithValue("@Password", Password);

                    connection.Open();

                    int result = (int)command.ExecuteScalar();

                    return result > 0;
                }
            }
        }
        public Supervisor Search(int supervisorId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, WorkNumber, Password FROM Supervisor WHERE Id = @SupervisorId";
                    cmd.Parameters.AddWithValue("@SupervisorId", supervisorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Supervisor> supervisors = new List<Supervisor>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string workNumber = reader.GetString(2);
                            string password = reader.GetString(3);

                            Supervisor supervisor = new Supervisor(id, name, workNumber, password);

                            supervisors.Add(supervisor);
                        }
                        return supervisors.FirstOrDefault(); // Return the first student found (or null if not found)
                    }
                }
            }
        }
    }
}
