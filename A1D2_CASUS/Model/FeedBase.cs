using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedBase
    {
        FeedBaseDAO db = new FeedBaseDAO();
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Supervisor ApprovedBy { get; set; }
        public Assignment Assignment { get; set; }
        public Student Student { get; set; }
        public string Content { get; set; }

        public FeedBase() { }
        public FeedBase(int id, DateTime creationDate, Supervisor approvedBy, Assignment assignment, Student student, string content)
        {
            Id = id;
            CreationDate = creationDate;
            ApprovedBy = approvedBy;
            Assignment = assignment;
            Student = student;
            Content = content;
        }

        public FeedBase Search(int id)
        {
            return db.Search(id);
        }

        public FeedBase SearchByAssignment(int id)
        {
            return db.SearchByAssignment(id);
        }
    }
}
