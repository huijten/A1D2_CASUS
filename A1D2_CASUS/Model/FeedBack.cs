using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedBack 
    {
        FeedBackDAO db = new FeedBackDAO();
        public int Id { get ; set; }
        public Assignment assignment { get; set; }
        public string Notes { get; set; }
        public int Bonuspoints { get; set; }

        public FeedBack() { }
        #region Constructors

       
        public FeedBack(int id, Assignment assignment, string notes)
        {
            Id = id;
            this.assignment = assignment;
            Notes = notes;
        }
        public FeedBack(int id, Assignment assignment, string notes, int bonuspoints)
        {
            Id = id;
            this.assignment = assignment;
            Notes = notes;
            Bonuspoints = bonuspoints;
        }
        public FeedBack( Assignment assignment, string notes, int bonuspoints)
        {
            this.assignment = assignment;
            Notes = notes;
            Bonuspoints = bonuspoints;
        }
        #endregion

        #region encapsulation

        internal DataTable Get2db4fdbck()
        {
            return db.GetFeedbackFromDatabase();
        }
        public void CreateFdbck(FeedBack feedback)
        {
            db.CreateFeedback(feedback);
        }
        public void UpdateFdbck(int id, FeedBase feed, string notes, int bonuspoints)
        {
            db.UpdateFeedBack(id, feed, notes,  bonuspoints);
        }
        public void DeleteFdbck(int id)
        {
            db.DeleteFeedback(id);
        }

        #endregion
    }
}
