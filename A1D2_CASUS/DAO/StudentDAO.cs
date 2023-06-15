using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class StudentDAO
    {
        public List<Student> students = new List<Student>();

        private string connectionString = "Server=.;Database=Gamification; Trusted_Connection=True";

        public void Read()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, StudentNumber, Password, XP FROM Students";

                }

            }
        }
    }
}
