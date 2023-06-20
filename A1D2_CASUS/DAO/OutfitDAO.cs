using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class OutfitDAO
    {
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";

        #region Getting all Outfits from database
        public List<Outfit> Read()
        {
            List<Outfit> outfits = new List<Outfit>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, Description, ImageURL, Cost FROM Outfit";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string description = reader.GetString(2);
                            string imageURL = reader.GetString(3);
                            int cost = reader.GetInt32(4);
                            Outfit outfit = new Outfit(id, name, description, imageURL, cost);

                            outfits.Add(outfit);
                        }
                    }
                }
            }

            return outfits;
        }
    }
    #endregion
}
