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
        public Assignment Assignment { get; set; }
        public Student Student { get; set; }
        public string Content { get; set; }

        public string SeeIds
        {
            get
            {
                return $"{Id} {ApprovedBy} {Assignment} {Student}";
            }
        }
        #region Constructor
        public FeedBase() { }
        public FeedBase(int id, DateTime creationDate, string content)   
        {
            Id = id;
            CreationDate = creationDate;
            Content = content;
        }
        public FeedBase(int id, DateTime creationDate, Supervisor approvedBy, Assignment assignment, Student student, string content)
        {
            Id = id;
            CreationDate = creationDate;
            ApprovedBy = approvedBy;
            Assignment = assignment;
            Student = student;
            Content = content;
        }
        public FeedBase(DateTime creationDate, Supervisor approvedBy, Assignment assignment, Student student, string content)
        {
            CreationDate = creationDate;
            ApprovedBy = approvedBy;
            Assignment = assignment;
            Student = student;
            Content = content;
        }
        #endregion
        public FeedBase Search(int id)
        {
            return db.Search(id);
        }
        

        public FeedBase SearchByAssignment(int id)
        {
            return db.SearchByAssignment(id);
        }
        #region CRUD
        
        public List<FeedBase> RDLIST()
        {
            return db.ReadFeedbase();
        }
        public DataTable Get2DB4FB()
        {
            return db.GetFeedbaseFromDatabase();
        }
        internal void CRTfb(FeedBase fb)
        {
            db.CreateFeedbase(fb);
        }
        internal void UPDfb(int id, DateTime CreationDate, Supervisor approvedby, Assignment assignment, Student student, string content)
        {
            db.UpdateFeedbase(id, CreationDate, approvedby, assignment, student, content);
        }
        internal void DELfb(int id)
        {
            db.DeletFeedBase(id);
        }
        #endregion
        

    }
}
