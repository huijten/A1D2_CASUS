using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentNumber { get; set; }
        public string Password { get; set; }
        public List<Outfit> Outfits { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }

        public Student(int id, string name, string studentNumber, string password, List<Outfit> outfits, int xP)
        {
            Id = id;
            Name = name;
            StudentNumber = studentNumber;
            Password = password;
            Outfits = outfits;
            XP = xP;
            Level = xP / 5;
        }
    }
}
