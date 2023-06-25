using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Supervisor Supervisor { get; set; }
        public Assignment Assignment { get; set; }
        public Student Student { get; set; }
        public string Content { get; set; }

        public FeedBase() { }
        public FeedBase(int id, DateTime creationDate, Supervisor approvedBy, Assignment assignment, Student student, string content)
        {
            Id = id;
            CreationDate = creationDate;
            Supervisor = approvedBy;
            Assignment = assignment;
            Student = student;
            Content = content;
        }
        public FeedBase(int id, DateTime creationDate, Supervisor approvedBy, Supervisor supervisor, Assignment assignment, Student student, string content)
        {
            Id = id;
            CreationDate = creationDate;
            Supervisor = approvedBy;
            Supervisor = supervisor;
            Assignment = assignment;
            Student = student;
            Content = content;
        }
        public FeedBase( DateTime creationDate, Supervisor supervisor, Assignment assignment, Supervisor approvedById ,Student student, string content)
        {
            CreationDate = creationDate;
            Supervisor = supervisor;
            Assignment = assignment;
            Supervisor = approvedById;
            
            Student = student;
            Content = content;
        }
        public FeedBase( DateTime creationDate, Supervisor approvedById, Assignment assignmentId, Student student, string content)
        {
            CreationDate = creationDate;
            ApprovedBy = approvedById;
            Assignment = assignmentId;
            Student = student;
            Content = content;
        }
        public FeedBase(int feeditemId, DateTime creationDate, Assignment assignment,  Supervisor approvedBy,  Student student, string content)
        {
            Id = feeditemId;
            CreationDate = creationDate;
            Assignment = assignment;
            
            ApprovedBy = approvedBy;
            Student = student;
            Content = content;
        }


        #region encapsulation

        internal DataTable Get2db4fdbs()
        {
            return db.GetFeedBaseFromDatabase();
        }
        public int GetlastFeedId()
        {
            return db.GetLastFeedId();
        }
        public void CreateFdbs(DateTime creationDate, Assignment assignment,  Student student, string content)
        {
           // db.CreateFeedbase(creationDate, assignment,  student, content);
        }
        public void CreateFdb(FeedBase feedbase)
        {
            db.CreateFeedbaze(feedbase);
        }
        public void UpdateFdbs(int id, FeedBase feed, string notes, int bonuspoints)
        {
            //db.UpdateFeedBack(id, feed, notes, bonuspoints);
        }
        public void DeleteFdbs(int id)
        {
            //db.DeleteFeedback(id);
        }

        #endregion
        
        public FeedBase Search(int id)
        {
            return db.Search(id);
        }
    }
}
