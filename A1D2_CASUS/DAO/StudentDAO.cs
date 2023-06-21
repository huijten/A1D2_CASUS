﻿using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.DAO
{
    public class StudentDAO
    {

        private string connectionString = @"Data Source=MSI;Initial Catalog=Gamification;Integrated Security=True";

        #region Getting all students from database
        public List<Student> Read()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT s.Id, s.Name, s.StudentNumber, s.Password, s.XP, s.Points," +
                        "o.Id AS OutfitId, o.Name AS OutfitName, o.Description AS OutfitDescription," +
                        "o.ImageURL AS OutfitImageURL, o.Cost AS OutfitCost " +
                        "FROM Student s " +
                        "LEFT JOIN StudentOutfit os ON s.Id = os.StudentId " +
                        "LEFT JOIN Outfit o ON os.OutfitId = o.Id";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int studentNumber = reader.GetInt32(2);
                            string password = reader.GetString(3);
                            int xp = reader.GetInt32(4);
                            int points = reader.GetInt32(5);

                            int outfitId = reader.GetInt32(6);
                            string outfitName = reader.GetString(7);
                            string outfitDescription = reader.GetString(8);
                            string outfitImageUrl = reader.GetString(9);
                            int outfitCost = reader.GetInt32(10);

                            Outfit outfit = new Outfit(outfitId, outfitName, outfitDescription, outfitImageUrl, outfitCost);

                            // Check if the student already exists in the list
                            Student student = students.FirstOrDefault(s => s.Id == id);
                            if (student == null)
                            {
                                // Create a new student
                                student = new Student(id, name, studentNumber, password, new List<Outfit> { outfit }, xp, points);
                                students.Add(student);
                            }
                            else
                            {
                                // Add the outfit to the existing student
                                student.Outfits.Add(outfit);
                            }
                        }
                    }
                }
            }

            return students;
        }

        #endregion

        #region Getting Student by Id
        public Student Search(int studentId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT s.Id, s.Name, s.StudentNumber, s.Password, s.XP, s.Points" +
                        "o.Id AS OutfitId, o.Name AS OutfitName, o.Description AS OutfitDescription," +
                        "o.ImageURL AS OutfitImageURL, o.Cost AS OutfitCost " +
                        "FROM Student s " +
                        "LEFT JOIN StudentOutfit os ON s.Id = os.StudentId " +
                        "LEFT JOIN Outfit o ON os.OutfitId = o.Id " +
                        "WHERE s.Id = @StudentId";
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Student> students = new List<Student>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int studentNumber = reader.GetInt32(2);
                            string password = reader.GetString(3);
                            int xp = reader.GetInt32(4);
                            int points = reader.GetInt32(5);

                            int outfitId = reader.GetInt32(5);
                            string outfitName = reader.GetString(6);
                            string outfitDescription = reader.GetString(7);
                            string outfitImageUrl = reader.GetString(8);
                            int outfitCost = reader.GetInt32(9);

                            Outfit outfit = new Outfit(outfitId, outfitName, outfitDescription, outfitImageUrl, outfitCost);

                            // Check if the student already exists in the list
                            Student student = students.FirstOrDefault(s => s.Id == id);
                            if (student == null)
                            {
                                // Create a new student
                                student = new Student(id, name, studentNumber, password, new List<Outfit> { outfit }, xp, points);
                                students.Add(student);
                            }
                            else
                            {
                                // Add the outfit to the existing student
                                student.Outfits.Add(outfit);
                            }
                        }

                        return students.FirstOrDefault(); // Return the first student found (or null if not found)
                    }
                }
            }
        }

        #endregion

        #region Unlock Outfit
        public bool UnlockOutfit(Student student, Outfit outfit)
        {
            if (student.Points >= outfit.Cost)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cnn.ConnectionString = connectionString;
                        cnn.Open();
                        cmd.Connection = cnn;

                        // Deduct the outfit cost from the student's XP in the database
                        cmd.CommandText = "UPDATE Student SET Points = Points - @OutfitCost WHERE Id = @StudentId";
                        cmd.Parameters.AddWithValue("@OutfitCost", outfit.Cost);
                        cmd.Parameters.AddWithValue("@StudentId", student.Id);
                        cmd.ExecuteNonQuery();

                        // Insert the outfit into the StudentOutfit table
                        cmd.CommandText = "INSERT INTO StudentOutfit (StudentId, OutfitId) VALUES (@StudentId, @OutfitId)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@StudentId", student.Id);
                        cmd.Parameters.AddWithValue("@OutfitId", outfit.Id);
                        cmd.ExecuteNonQuery();

                        student.Outfits.Add(outfit);  // Add the outfit to the student's collection
                        student.Points -= outfit.Cost;  // Deduct the outfit cost from the student's XP

                        return true;  // Outfit unlocked successfully
                    }
                }
            }
            return false;  // Not enough XP to unlock the outfit
        }
        #endregion
    }
}
