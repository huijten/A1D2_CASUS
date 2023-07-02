using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Student
    {
        StudentDAO db = new StudentDAO();

        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public string Password { get; set; }
        public List<Outfit> Outfits { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }

        public Student() { }
        public Student(int id, string name, int studentNumber, string password, List<Outfit> outfits, int xP, int points)
        {
            Id = id;
            Name = name;
            StudentNumber = studentNumber;
            Password = password;
            Outfits = outfits;
            XP = xP;
            Level = xP / 5;
            Points = points;
        }

        public DataTable GetStudents()
        {
            return db.GetemStudents();
        }
        public bool validatestudent(string StudentNumber, string Password)
        {
            return db.Validatecred(StudentNumber, Password);
        }
        public List<Student> Read()
        {
            return db.Read();
        }

        public Student Search(int id)
        {
            return db.Search(id);
        }

        public void UnlockOutfit(Student student, Outfit outfit)
        {
            db.UnlockOutfit(this, outfit);
        }
    }
}
