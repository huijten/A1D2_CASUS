using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Assignment
    {
        AssignmentDAO db = new AssignmentDAO();
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public bool isCompleted { get; set; }
        public int Points { get; set; }

        public Assignment() { }
        public Assignment(int id, string name, DateTime deadline, bool isCompleted, int points)
        {
            Id = id;
            Name = name;
            Deadline = deadline;
            this.isCompleted = isCompleted;
            Points = points;
        }
        public Assignment( string name, DateTime deadline, bool isCompleted, int points)
        {
            Name = name;
            Deadline = deadline;
            this.isCompleted = isCompleted;
            Points = points;
        }

        public Assignment Getlastassign()
        {
            return db.GetLast();
        }
        public Assignment Search(int Id)
        {
            return db.Search(Id);
        }
        #region Crud
        internal DataTable Get2d4bAsnmt()
        {
            return db.GetAssignmentFromDatabase();
        }
        public void CreateAsnmt(Assignment assignment)
        {
            db.CreateAssignment(assignment);
        }
        public void UpdateAsnmt(int id, string Name, DateTime Deadline, bool isCompleted, int Points)
        {
            db.UpdateAssignment(id, Name, Deadline,isCompleted, Points);
        }
        public void DeleteAsnmt(int id)
        {
            db.DeleteAssignment(id);
        }
        #endregion
    }
}
