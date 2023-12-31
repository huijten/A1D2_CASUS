﻿using A1D2_CASUS.Model;
using A1D2_CASUS.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.Extensions.Configuration;

namespace A1D2_CASUS.DAO
{

    public class AssignmentDAO : Constring
    {
        #region C.R.U.D
        internal DataTable GetAssignmentFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * From Assignment"; ;
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
        internal void CreateAssignment(Assignment assignment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Assignment (Name, Deadline, isCompleted, Points) VALUES (@Name, @Deadline, @isCompleted, @Points)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Name", assignment.Name);
                        command.Parameters.AddWithValue("@Deadline", assignment.Deadline);
                        command.Parameters.AddWithValue("@isCompleted", assignment.isCompleted);
                        command.Parameters.AddWithValue("@Points", assignment.Points);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void UpdateAssignment(int id, string Name, DateTime Deadline, bool isCompleted, int Points) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Assignment SET Name = @Name, Deadline = @Deadline, isCompleted = @isCompleted, Points = @Points WHERE id = @Id ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Deadline", Deadline);
                        command.Parameters.AddWithValue("@isCompleted", isCompleted);
                        command.Parameters.AddWithValue("@Points", Points);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        internal void DeleteAssignment(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE Assignment WHERE id = @Id";
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

        #region Search

        internal Assignment GetLast()
        {
            List<Assignment> list = new List<Assignment>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT TOP 1 * FROM Assignment ORDER BY Id DESC";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            list.Clear();
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            DateTime date = reader.GetDateTime(2);
                            bool isCompleted = reader.GetBoolean(3);
                            int points = reader.GetInt32(4);
                            Assignment assignment = new Assignment(id, name, date, isCompleted, points);
                            list.Add(assignment);
                        }
                    return list.FirstOrDefault();
                }

                
            }
        }
        public Assignment Search(int assignmentId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT Id, Name, Deadline, isCompleted, Points FROM Assignment WHERE Id = @AssignmentId";
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
