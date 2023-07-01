﻿using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class FeedForwardDAO
    {
        //Kevin
        private string connectionString = @"Server=COMPUTER\SQLEXPRESS; Database=Gamification; Trusted_Connection=True";
        //Ruben
        //private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";
        //Wien
        //private string connectionString = @"Server=.; Database=Gamification; Trusted_Connection=True";

        #region Getting all FeedForwards from database
        public List<FeedForward> Read()
        {
            List<FeedForward> feedforwards = new List<FeedForward>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Feed, Notes FROM FeedForward";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int feedBaseId = reader.GetInt32(1);
                            string notes = reader.GetString(2);

                            // Get FeedBase by FeedId                            
                            FeedBase feed = new FeedBase();

                            FeedForward feedforward = new FeedForward(id, feed.Search(feedBaseId), notes);
                            feedforwards.Add(feedforward);
                        }
                    }
                }
            }

            return feedforwards;
        }
        #endregion

        #region Creating FeedForward
        public void Create(FeedForward feedForward)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO FeedForward (Feed, Notes) VALUES (@Feed, @Notes)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Feed", feedForward.Feed.Id);
                        command.Parameters.AddWithValue("@Notes", feedForward.Notes);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        #endregion
    }
    

}

