using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class SupervisorDAO
    {
        //Kevin
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
        //Ruben
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
        //Wien
        //private string connectionString = @"Server=.; Database=Gamification; Trusted_Connection=True";

        public Supervisor Search(int supervisorId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, WorkNumber, Password WHERE Id = @SupervisorId";
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
